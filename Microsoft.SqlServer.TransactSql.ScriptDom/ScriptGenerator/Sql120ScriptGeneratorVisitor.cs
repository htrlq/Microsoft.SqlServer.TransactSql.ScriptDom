using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator
{
	// Token: 0x020001A6 RID: 422
	internal class Sql120ScriptGeneratorVisitor : SqlScriptGeneratorVisitor
	{
		// Token: 0x0600100A RID: 4106 RVA: 0x00035D2D File Offset: 0x00033F2D
		public Sql120ScriptGeneratorVisitor(SqlScriptGeneratorOptions options, ScriptWriter writer) : base(options, writer)
		{
			options.SqlVersion = SqlVersion.Sql120;
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x00035D3E File Offset: 0x00033F3E
		internal override HashSet<Type> StatementsThatCannotHaveSemiColon
		{
			get
			{
				return Sql120ScriptGeneratorVisitor._typesCantHaveSemiColon;
			}
		}

		// Token: 0x0400104A RID: 4170
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
