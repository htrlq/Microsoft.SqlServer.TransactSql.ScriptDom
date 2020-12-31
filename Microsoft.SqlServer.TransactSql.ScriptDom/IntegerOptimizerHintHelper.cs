using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000E1 RID: 225
	internal class IntegerOptimizerHintHelper : OptionsHelper<OptimizerHintKind>
	{
		// Token: 0x06000272 RID: 626 RVA: 0x0000871C File Offset: 0x0000691C
		private IntegerOptimizerHintHelper()
		{
			base.AddOptionMapping(OptimizerHintKind.Fast, "FAST", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(OptimizerHintKind.MaxDop, "MAXDOP", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(OptimizerHintKind.UsePlan, "USEPLAN", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(OptimizerHintKind.MaxRecursion, "MAXRECURSION", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(OptimizerHintKind.QueryTraceOn, "QUERYTRACEON", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(OptimizerHintKind.CardinalityTunerLimit, "CARDINALITY_TUNER_LIMIT", SqlVersionFlags.TSql100AndAbove);
		}

		// Token: 0x04000B9D RID: 2973
		internal static readonly IntegerOptimizerHintHelper Instance = new IntegerOptimizerHintHelper();
	}
}
