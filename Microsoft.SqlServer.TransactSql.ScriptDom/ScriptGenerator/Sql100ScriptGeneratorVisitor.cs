using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator
{
	// Token: 0x020001A4 RID: 420
	internal class Sql100ScriptGeneratorVisitor : SqlScriptGeneratorVisitor
	{
		// Token: 0x06001004 RID: 4100 RVA: 0x00035B2D File Offset: 0x00033D2D
		public Sql100ScriptGeneratorVisitor(SqlScriptGeneratorOptions options, ScriptWriter writer) : base(options, writer)
		{
			options.SqlVersion = SqlVersion.Sql100;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x00035B3E File Offset: 0x00033D3E
		internal override HashSet<Type> StatementsThatCannotHaveSemiColon
		{
			get
			{
				return Sql100ScriptGeneratorVisitor._typesCantHaveSemiColon;
			}
		}

		// Token: 0x04001048 RID: 4168
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
