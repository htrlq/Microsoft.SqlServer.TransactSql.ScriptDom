using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using AssemblyName = System.Reflection.AssemblyName;

namespace Builder.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var hello = new Hello();
            var sql = "select id from UserTable where id = @id";

            var analysis = new AnalysisSQL();

            analysis.Print(sql);

            Console.ReadLine();
        }

        static object CreateInstance(BuilderDynamic build, Type paramType)
        {
            #region BuilderVisitorType

            var paramExpression = Expression.Parameter(typeof(string), "typeName");
            var builderVisitorTypeMethod = typeof(BuilderDynamic).GetMethod("BuilderVisitorType").MakeGenericMethod(new Type[] { paramType });
            var buildInstance = Expression.Constant(build);
            var builderVisitorTypeCall = Expression.Call(buildInstance, builderVisitorTypeMethod, paramExpression);
            var builderVisitorType = Expression
                .Lambda<Func<string, Type>>(builderVisitorTypeCall, new ParameterExpression[] { paramExpression })
                .Compile();

            var _type = builderVisitorType(paramType.Name);

            return Activator.CreateInstance(_type);
            #endregion
        }
    }

    internal class AnalysisSQL
    {
        private List<AbsTSqlFragmentVisitor> visitors = new List<AbsTSqlFragmentVisitor>();

        public AnalysisSQL()
        {
            var build = new BuilderDynamic();

            var methods = typeof(TSqlFragmentVisitor).GetMethods().Where(_method=>_method.Name == "Visit").ToList();

            foreach (var method in typeof(TSqlFragmentVisitor).GetAllVisit())
            {
                Console.WriteLine($"Params:{string.Join(",", method.GetParameters().Select(_param => _param.ParameterType.Name))}");
                var paramType = method.GetParameters().Select(_param => _param.ParameterType).FirstOrDefault();

                var type = CreateType(build, paramType);
                //var instance = Activator.CreateInstance(type);

                //visitors.Add((AbsTSqlFragmentVisitor)instance);
            }

            build.Save($"Proxy.dll");
        }

        private Type CreateType(BuilderDynamic build, Type paramType)
        {
            #region BuilderVisitorType

            var paramExpression = Expression.Parameter(typeof(string), "typeName");
            var builderVisitorTypeMethod = typeof(BuilderDynamic).GetMethod("BuilderVisitorType").MakeGenericMethod(new Type[] { paramType });
            var buildInstance = Expression.Constant(build);
            var builderVisitorTypeCall = Expression.Call(buildInstance, builderVisitorTypeMethod, paramExpression);
            var builderVisitorType = Expression
                .Lambda<Func<string, Type>>(builderVisitorTypeCall, new ParameterExpression[] { paramExpression })
                .Compile();

            var _type = builderVisitorType(paramType.Name);

            return _type;

            #endregion
        }

        public void Print(string sql)
        {
            TSql150Parser parser = new TSql150Parser(false);

            using (var reader = new StringReader(sql))
            {
                TSqlFragment fragment = parser.Parse(reader, out IList<ParseError> errors);

                if (errors.Count > 0)
                {
                    throw new Exception($"{string.Join(",", errors.Select(_error => _error.Message))}");
                }

                foreach (var visitor in visitors)
                {
                    fragment.Accept(visitor);

                    visitor.Print(sql);
                }
            }
        }
    }

    public abstract class AbsTSqlFragmentVisitor: TSqlFragmentVisitor
    {
        public abstract void Print(string sql);
    }

    public class Hello: AbsTSqlFragmentVisitor
    {
        private List<TSqlFragment> _list;

        public Hello()
        {
            _list = new List<TSqlFragment>();
        }

        public override void Print(string sql)
        {
            foreach (var item in _list)
            {
                Console.WriteLine($"{GetType().Name.Replace("Proxy","")} Sql:{sql} Result:{sql.Substring(item.StartOffset, item.FragmentLength)}");
            }
        }

        public override void Visit(TSqlFragment fragment)
        {
            _list.Add(fragment);
            base.Visit(fragment);
        }

        
    }

    static class ReflectExtension
    {
        public static Expression ForEach(Expression collection, ParameterExpression loopVar, Expression loopContent)
        {
            var elementType = loopVar.Type;
            var enumerableType = typeof(IEnumerable<>).MakeGenericType(elementType);
            var enumeratorType = typeof(IEnumerator<>).MakeGenericType(elementType);

            var enumeratorVar = Expression.Variable(enumeratorType, "enumerator");
            var getEnumeratorCall = Expression.Call(collection, enumerableType.GetMethod("GetEnumerator"));
            var enumeratorAssign = Expression.Assign(enumeratorVar, getEnumeratorCall);

            // The MoveNext method's actually on IEnumerator, not IEnumerator<T>
            var moveNextCall = Expression.Call(enumeratorVar, typeof(IEnumerator).GetMethod("MoveNext"));

            var breakLabel = Expression.Label("LoopBreak");

            var loop = Expression.Block(new[] { enumeratorVar },
                enumeratorAssign,
                Expression.Loop(
                    Expression.IfThenElse(
                        Expression.Equal(moveNextCall, Expression.Constant(true)),
                        Expression.Block(new[] { loopVar },
                            Expression.Assign(loopVar, Expression.Property(enumeratorVar, "Current")),
                            loopContent
                        ),
                        Expression.Break(breakLabel)
                    ),
                    breakLabel)
            );

            return loop;
        }

        public static List<MethodInfo> GetAllVisit(this Type type)
        {
            var array = type.GetMethods().Where(_method => _method.Name == "Visit").ToList();

            return array;
        }
    }

    internal class BuilderDynamic
    {
        private AssemblyName _assemblyName;
        private AssemblyBuilder _assemblyBuilder;
        private ModuleBuilder _moduleBuilder;

        public BuilderDynamic()
        {
            _assemblyName = new AssemblyName("Builder.Sample");
            _assemblyName.Version = new Version(0, 1);
            _assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(_assemblyName, AssemblyBuilderAccess.RunAndSave);
            _moduleBuilder = _assemblyBuilder.DefineDynamicModule("ProxyImpl", "Proxy.dll");
        }

        public Type BuilderVisitorType<TVisitor>(string typeName)
        {
            var typeBuilder = _moduleBuilder.DefineType($"Proxy_{typeName}", TypeAttributes.Class | TypeAttributes.Sealed, typeof(AbsTSqlFragmentVisitor), new Type[]{  });

            var list = typeBuilder.DefineField("_list", typeof(List<>).MakeGenericType(typeof(TVisitor)), FieldAttributes.Private);

            #region BuilderConstructor
            var constructorMethod = typeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, new Type[] { });
            var constructorIlGenerator = constructorMethod.GetILGenerator();

            var ctorMethod = typeof(TSqlFragmentVisitor).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, Type.EmptyTypes, null);

            if (ctorMethod != null)
            {
                //call TSource ctor
                constructorIlGenerator.Emit(OpCodes.Ldarg_0);
                constructorIlGenerator.Emit(OpCodes.Call, ctorMethod);
                constructorIlGenerator.Emit(OpCodes.Nop);
                constructorIlGenerator.Emit(OpCodes.Nop);
            }

            //param1 set List<string> _list
            constructorIlGenerator.Emit(OpCodes.Ldarg_0);
            constructorIlGenerator.Emit(OpCodes.Newobj, typeof(List<>).MakeGenericType(typeof(TVisitor)).GetConstructor(Type.EmptyTypes));
            constructorIlGenerator.Emit(OpCodes.Stfld, list);

            constructorIlGenerator.Emit(OpCodes.Ret);
            #endregion

            //#region Property Node
            //var nodeBuilder = typeBuilder.DefineProperty("Node", PropertyAttributes.HasDefault, typeof(List<>).MakeGenericType(typeof(TVisitor)), null);
            //var nodeGetBuilder = typeBuilder.DefineMethod(
            //    "get_Node",
            //    MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig,
            //    typeof(List<>).MakeGenericType(typeof(TVisitor)),
            //    Type.EmptyTypes);
            //ILGenerator nodeGetBuilderIl = nodeGetBuilder.GetILGenerator();

            //nodeGetBuilderIl.Emit(OpCodes.Ldarg_0);
            //nodeGetBuilderIl.Emit(OpCodes.Ldfld, list);
            //nodeGetBuilderIl.Emit(OpCodes.Ret);

            //nodeBuilder.SetGetMethod(nodeGetBuilder);
            //#endregion

            #region BuildMethodVisit
            var visitGetBuilder = typeBuilder.DefineMethod(
                "Visit",
                MethodAttributes.Public | MethodAttributes.Virtual,
                typeof(void),
                new Type[]{ typeof(TVisitor) });
            var visitGetBuilderIl = visitGetBuilder.GetILGenerator();

            //list.Add(param1)
            visitGetBuilderIl.Emit(OpCodes.Nop);
            visitGetBuilderIl.Emit(OpCodes.Ldarg_0);
            visitGetBuilderIl.Emit(OpCodes.Ldfld, list);
            visitGetBuilderIl.Emit(OpCodes.Ldarg_1);
            visitGetBuilderIl.Emit(OpCodes.Callvirt, typeof(List<>).MakeGenericType(typeof(TVisitor)).GetMethod("Add"));

            //base.Visit(param1)
            visitGetBuilderIl.Emit(OpCodes.Nop);
            visitGetBuilderIl.Emit(OpCodes.Ldarg_0);
            visitGetBuilderIl.Emit(OpCodes.Ldarg_1);
            visitGetBuilderIl.Emit(OpCodes.Call, typeof(TSqlFragmentVisitor).GetMethod("Visit", new Type[] { typeof(TVisitor) }));

            visitGetBuilderIl.Emit(OpCodes.Nop);
            visitGetBuilderIl.Emit(OpCodes.Ret);
            #endregion

            #region BuildPrint
            var printBuilder = typeBuilder.DefineMethod(
                "Print",
                MethodAttributes.Public | MethodAttributes.Virtual,
                typeof(void),
                new Type[] { typeof(string) });
            var printBuilderIl = printBuilder.GetILGenerator();

            var local0 = printBuilderIl.DeclareLocal(typeof(List<>.Enumerator).MakeGenericType(typeof(TVisitor)));
            var local1 = printBuilderIl.DeclareLocal(typeof(TVisitor));

            var IL_0071 = printBuilderIl.DefineLabel();
            var IL_0010 = printBuilderIl.DefineLabel();
            var IL_008b = printBuilderIl.DefineLabel();

            printBuilderIl.Emit(OpCodes.Nop);
            printBuilderIl.Emit(OpCodes.Nop);
            printBuilderIl.Emit(OpCodes.Ldarg_0);
            printBuilderIl.Emit(OpCodes.Ldfld, list);
            printBuilderIl.Emit(OpCodes.Callvirt, typeof(List<>).MakeGenericType(typeof(TVisitor)).GetMethod("GetEnumerator"));
            printBuilderIl.Emit(OpCodes.Stloc, local0);

            printBuilderIl.BeginExceptionBlock();

            printBuilderIl.Emit(OpCodes.Br_S, IL_0071);
            printBuilderIl.MarkLabel(IL_0010);
            printBuilderIl.Emit(OpCodes.Ldloca_S, local0);
            printBuilderIl.Emit(OpCodes.Call, typeof(List<>.Enumerator).MakeGenericType(typeof(TVisitor)).GetMethod("get_Current"));
            printBuilderIl.Emit(OpCodes.Stloc, local1);
            printBuilderIl.Emit(OpCodes.Nop); 
            printBuilderIl.Emit(OpCodes.Ldc_I4_5);
            printBuilderIl.Emit(OpCodes.Newarr, typeof(string));
            printBuilderIl.Emit(OpCodes.Dup);
            printBuilderIl.Emit(OpCodes.Ldc_I4_0);
            printBuilderIl.Emit(OpCodes.Ldarg_0);
            printBuilderIl.Emit(OpCodes.Call, typeof(object).GetMethod("GetType"));
            printBuilderIl.Emit(OpCodes.Callvirt, typeof(MethodInfo).GetMethod("get_Name"));
            printBuilderIl.Emit(OpCodes.Ldstr, "Proxy");
            printBuilderIl.Emit(OpCodes.Ldstr, "");
            printBuilderIl.Emit(OpCodes.Callvirt, typeof(string).GetMethod("Replace", new Type[]{ typeof(string), typeof(string) }));
            printBuilderIl.Emit(OpCodes.Stelem_Ref);
            printBuilderIl.Emit(OpCodes.Dup);
            printBuilderIl.Emit(OpCodes.Ldc_I4_1);
            printBuilderIl.Emit(OpCodes.Ldstr, " Sql:");
            printBuilderIl.Emit(OpCodes.Stelem_Ref);
            printBuilderIl.Emit(OpCodes.Dup);
            printBuilderIl.Emit(OpCodes.Ldc_I4_2);
            printBuilderIl.Emit(OpCodes.Ldarg_1);
            printBuilderIl.Emit(OpCodes.Stelem_Ref);
            printBuilderIl.Emit(OpCodes.Dup);
            printBuilderIl.Emit(OpCodes.Ldc_I4_3);
            printBuilderIl.Emit(OpCodes.Ldstr, " Result:");
            printBuilderIl.Emit(OpCodes.Stelem_Ref);
            printBuilderIl.Emit(OpCodes.Dup);
            printBuilderIl.Emit(OpCodes.Ldc_I4_4);
            printBuilderIl.Emit(OpCodes.Ldarg_1);
            printBuilderIl.Emit(OpCodes.Ldloc, local1);
            printBuilderIl.Emit(OpCodes.Callvirt, typeof(TVisitor).GetMethod("get_StartOffset"));
            printBuilderIl.Emit(OpCodes.Ldloc, local1);
            printBuilderIl.Emit(OpCodes.Callvirt, typeof(TVisitor).GetMethod("get_FragmentLength"));
            printBuilderIl.Emit(OpCodes.Callvirt, typeof(string).GetMethod("Substring", new Type[] { typeof(Int32), typeof(Int32) }));
            printBuilderIl.Emit(OpCodes.Stelem_Ref);
            printBuilderIl.Emit(OpCodes.Call, typeof(string).GetMethod("Concat", new Type[]{ typeof(string[]) }));
            printBuilderIl.Emit(OpCodes.Call, typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) }));
            printBuilderIl.Emit(OpCodes.Nop);
            printBuilderIl.Emit(OpCodes.Nop);

            printBuilderIl.MarkLabel(IL_0071);
            printBuilderIl.Emit(OpCodes.Ldloc, local0);
            printBuilderIl.Emit(OpCodes.Call, typeof(List<>.Enumerator).MakeGenericType(typeof(TVisitor)).GetMethod("MoveNext"));
            printBuilderIl.Emit(OpCodes.Brtrue_S, IL_0010);
            //printBuilderIl.Emit(OpCodes.Leave_S, IL_008b);

            printBuilderIl.BeginFinallyBlock();

            printBuilderIl.Emit(OpCodes.Ldloca_S, local0);
            printBuilderIl.Emit(OpCodes.Constrained, typeof(List<>.Enumerator).MakeGenericType(typeof(TVisitor)));
            printBuilderIl.Emit(OpCodes.Callvirt, typeof(IDisposable).GetMethod("Dispose"));
            printBuilderIl.Emit(OpCodes.Nop);
            //printBuilderIl.Emit(OpCodes.Endfinally);

            printBuilderIl.EndExceptionBlock();

            printBuilderIl.MarkLabel(IL_008b);
            printBuilderIl.Emit(OpCodes.Ret);
            #endregion

            var resulType = typeBuilder.CreateTypeInfo();

            return resulType;
        }

        public void Save(string assemblyFileName)
        {
            _assemblyBuilder.Save(assemblyFileName);
        }
    }
}
