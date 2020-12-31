using System;
using antlr;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000CF RID: 207
	internal class GroupByOptionHelper : OptionsHelper<GroupByOption>
	{
		// Token: 0x0600023E RID: 574 RVA: 0x000081CF File Offset: 0x000063CF
		private GroupByOptionHelper()
		{
			base.AddOptionMapping(GroupByOption.Cube, "CUBE");
			base.AddOptionMapping(GroupByOption.Rollup, "ROLLUP");
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000081F0 File Offset: 0x000063F0
		protected override TSqlParseErrorException GetMatchingException(IToken token)
		{
			return new TSqlParseErrorException(TSql80ParserBaseInternal.CreateParseError("SQL46023", token, TSqlParserResource.SQL46023Message, new string[]
			{
				token.getText()
			}));
		}

		// Token: 0x04000B57 RID: 2903
		internal static readonly GroupByOptionHelper Instance = new GroupByOptionHelper();
	}
}
