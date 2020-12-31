using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator
{
	// Token: 0x020001A5 RID: 421
	internal class Sql110ScriptGeneratorVisitor : SqlScriptGeneratorVisitor
	{
		// Token: 0x06001007 RID: 4103 RVA: 0x00035C2D File Offset: 0x00033E2D
		public Sql110ScriptGeneratorVisitor(SqlScriptGeneratorOptions options, ScriptWriter writer) : base(options, writer)
		{
			options.SqlVersion = SqlVersion.Sql110;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x00035C3E File Offset: 0x00033E3E
		internal override HashSet<Type> StatementsThatCannotHaveSemiColon
		{
			get
			{
				return Sql110ScriptGeneratorVisitor._typesCantHaveSemiColon;
			}
		}

		// Token: 0x04001049 RID: 4169
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
