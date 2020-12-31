using System;
using antlr;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000151 RID: 337
	internal class StatisticsOptionHelper : OptionsHelper<StatisticsOptionKind>
	{
		// Token: 0x060002FA RID: 762 RVA: 0x00009A9E File Offset: 0x00007C9E
		private StatisticsOptionHelper()
		{
			base.AddOptionMapping(StatisticsOptionKind.FullScan, "FULLSCAN");
			base.AddOptionMapping(StatisticsOptionKind.NoRecompute, "NORECOMPUTE");
			base.AddOptionMapping(StatisticsOptionKind.Resample, "RESAMPLE");
			base.AddOptionMapping(StatisticsOptionKind.Columns, "COLUMNS");
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00009AD8 File Offset: 0x00007CD8
		protected override TSqlParseErrorException GetMatchingException(IToken token)
		{
			return new TSqlParseErrorException(TSql80ParserBaseInternal.CreateParseError("SQL46020", token, TSqlParserResource.SQL46020Message, new string[]
			{
				token.getText()
			}));
		}

		// Token: 0x04000DE3 RID: 3555
		internal static readonly StatisticsOptionHelper Instance = new StatisticsOptionHelper();
	}
}
