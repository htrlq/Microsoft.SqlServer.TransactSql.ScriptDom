using System;
using antlr;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000083 RID: 131
	internal class ComputeFunctionTypeHelper : OptionsHelper<ComputeFunctionType>
	{
		// Token: 0x06000205 RID: 517 RVA: 0x00007114 File Offset: 0x00005314
		private ComputeFunctionTypeHelper()
		{
			base.AddOptionMapping(ComputeFunctionType.Count, "COUNT");
			base.AddOptionMapping(ComputeFunctionType.CountBig, "COUNT_BIG");
			base.AddOptionMapping(ComputeFunctionType.Max, "MAX");
			base.AddOptionMapping(ComputeFunctionType.Min, "MIN");
			base.AddOptionMapping(ComputeFunctionType.Sum, "SUM");
			base.AddOptionMapping(ComputeFunctionType.Avg, "AVG");
			base.AddOptionMapping(ComputeFunctionType.Var, "VAR");
			base.AddOptionMapping(ComputeFunctionType.Varp, "VARP");
			base.AddOptionMapping(ComputeFunctionType.Stdev, "STDEV");
			base.AddOptionMapping(ComputeFunctionType.Stdevp, "STDEVP");
			base.AddOptionMapping(ComputeFunctionType.ChecksumAgg, "CHECKSUM_AGG");
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000071B0 File Offset: 0x000053B0
		protected override TSqlParseErrorException GetMatchingException(IToken token)
		{
			return new TSqlParseErrorException(TSql80ParserBaseInternal.CreateParseError("SQL46024", token, TSqlParserResource.SQL46024Message, new string[]
			{
				token.getText()
			}));
		}

		// Token: 0x04000809 RID: 2057
		internal static readonly ComputeFunctionTypeHelper Instance = new ComputeFunctionTypeHelper();
	}
}
