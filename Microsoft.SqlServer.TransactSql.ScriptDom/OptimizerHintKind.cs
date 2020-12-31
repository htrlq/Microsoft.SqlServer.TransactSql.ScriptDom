using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000102 RID: 258
	[Serializable]
	public enum OptimizerHintKind
	{
		// Token: 0x04000C00 RID: 3072
		Unspecified,
		// Token: 0x04000C01 RID: 3073
		HashGroup,
		// Token: 0x04000C02 RID: 3074
		OrderGroup,
		// Token: 0x04000C03 RID: 3075
		MergeJoin,
		// Token: 0x04000C04 RID: 3076
		HashJoin,
		// Token: 0x04000C05 RID: 3077
		LoopJoin,
		// Token: 0x04000C06 RID: 3078
		ConcatUnion,
		// Token: 0x04000C07 RID: 3079
		HashUnion,
		// Token: 0x04000C08 RID: 3080
		MergeUnion,
		// Token: 0x04000C09 RID: 3081
		KeepUnion,
		// Token: 0x04000C0A RID: 3082
		ForceOrder,
		// Token: 0x04000C0B RID: 3083
		RobustPlan,
		// Token: 0x04000C0C RID: 3084
		KeepPlan,
		// Token: 0x04000C0D RID: 3085
		KeepFixedPlan,
		// Token: 0x04000C0E RID: 3086
		ExpandViews,
		// Token: 0x04000C0F RID: 3087
		AlterColumnPlan,
		// Token: 0x04000C10 RID: 3088
		ShrinkDBPlan,
		// Token: 0x04000C11 RID: 3089
		BypassOptimizerQueue,
		// Token: 0x04000C12 RID: 3090
		UsePlan,
		// Token: 0x04000C13 RID: 3091
		ParameterizationSimple,
		// Token: 0x04000C14 RID: 3092
		ParameterizationForced,
		// Token: 0x04000C15 RID: 3093
		OptimizeCorrelatedUnionAll,
		// Token: 0x04000C16 RID: 3094
		Recompile,
		// Token: 0x04000C17 RID: 3095
		Fast,
		// Token: 0x04000C18 RID: 3096
		CheckConstraintsPlan,
		// Token: 0x04000C19 RID: 3097
		MaxRecursion,
		// Token: 0x04000C1A RID: 3098
		MaxDop,
		// Token: 0x04000C1B RID: 3099
		QueryTraceOn,
		// Token: 0x04000C1C RID: 3100
		CardinalityTunerLimit,
		// Token: 0x04000C1D RID: 3101
		TableHints,
		// Token: 0x04000C1E RID: 3102
		OptimizeFor,
		// Token: 0x04000C1F RID: 3103
		IgnoreNonClusteredColumnStoreIndex
	}
}
