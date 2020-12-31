using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator
{
	// Token: 0x020001A8 RID: 424
	internal class Sql90ScriptGeneratorVisitor : SqlScriptGeneratorVisitor
	{
		// Token: 0x06001012 RID: 4114 RVA: 0x00036036 File Offset: 0x00034236
		public Sql90ScriptGeneratorVisitor(SqlScriptGeneratorOptions options, ScriptWriter writer) : base(options, writer)
		{
			options.SqlVersion = SqlVersion.Sql90;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x00036047 File Offset: 0x00034247
		internal override HashSet<Type> StatementsThatCannotHaveSemiColon
		{
			get
			{
				return Sql90ScriptGeneratorVisitor._typesCantHaveSemiColon;
			}
		}

		// Token: 0x0400104C RID: 4172
		private static HashSet<Type> _typesCantHaveSemiColon = new HashSet<Type>
		{
			typeof(CreateProcedureStatement),
			typeof(AlterProcedureStatement),
			typeof(CreateFunctionStatement),
			typeof(AlterFunctionStatement),
			typeof(CreateTriggerStatement),
			typeof(AlterTriggerStatement),
			typeof(TSqlStatementSnippet),
			typeof(BeginEndBlockStatement),
			typeof(IfStatement),
			typeof(WhileStatement),
			typeof(LabelStatement),
			typeof(TryCatchStatement)
		};
	}
}
