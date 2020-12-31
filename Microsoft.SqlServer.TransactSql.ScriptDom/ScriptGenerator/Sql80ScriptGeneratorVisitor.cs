using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator
{
	// Token: 0x020001A7 RID: 423
	internal sealed class Sql80ScriptGeneratorVisitor : SqlScriptGeneratorVisitor
	{
		// Token: 0x0600100D RID: 4109 RVA: 0x00035E2D File Offset: 0x0003402D
		public Sql80ScriptGeneratorVisitor(SqlScriptGeneratorOptions options, ScriptWriter writer) : base(options, writer)
		{
			options.SqlVersion = SqlVersion.Sql80;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00035E40 File Offset: 0x00034040
		protected override void GenerateIndexOptions(IList<IndexOption> options)
		{
			if (options != null && options.Count > 0)
			{
				bool flag = true;
				foreach (IndexOption indexOption in options)
				{
					IndexStateOption indexStateOption = indexOption as IndexStateOption;
					if (indexStateOption == null || indexStateOption.OptionState == OptionState.On)
					{
						if (flag)
						{
							flag = false;
							base.NewLineAndIndent();
							base.GenerateKeyword(TSqlTokenType.With);
							base.GenerateSpace();
						}
						else
						{
							base.GenerateSymbolAndSpace(TSqlTokenType.Comma);
						}
						base.GenerateFragmentIfNotNull(indexOption);
					}
				}
			}
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00035ED4 File Offset: 0x000340D4
		public override void ExplicitVisit(IndexStateOption node)
		{
			if (node.OptionState == OptionState.On)
			{
				IndexOptionHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00035EF5 File Offset: 0x000340F5
		internal override HashSet<Type> StatementsThatCannotHaveSemiColon
		{
			get
			{
				return Sql80ScriptGeneratorVisitor._typesCantHaveSemiColon;
			}
		}

		// Token: 0x0400104B RID: 4171
		private static HashSet<Type> _typesCantHaveSemiColon = new HashSet<Type>
		{
			typeof(CreateViewStatement),
			typeof(AlterViewStatement),
			typeof(CreateFunctionStatement),
			typeof(AlterFunctionStatement),
			typeof(CreateDefaultStatement),
			typeof(CreateRuleStatement),
			typeof(CreateSchemaStatement),
			typeof(TSqlStatementSnippet),
			typeof(CreateTriggerStatement),
			typeof(AlterTriggerStatement),
			typeof(CreateProcedureStatement),
			typeof(AlterProcedureStatement),
			typeof(BeginEndBlockStatement),
			typeof(IfStatement),
			typeof(WhileStatement),
			typeof(LabelStatement),
			typeof(TryCatchStatement)
		};
	}
}
