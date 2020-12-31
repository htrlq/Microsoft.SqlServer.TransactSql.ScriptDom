using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000113 RID: 275
	internal class PlanOptimizerHintHelper : OptionsHelper<OptimizerHintKind>
	{
		// Token: 0x060002CB RID: 715 RVA: 0x00008E5C File Offset: 0x0000705C
		private PlanOptimizerHintHelper()
		{
			base.AddOptionMapping(OptimizerHintKind.RobustPlan, "ROBUST", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(OptimizerHintKind.ShrinkDBPlan, "SHRINKDB", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(OptimizerHintKind.AlterColumnPlan, "ALTERCOLUMN", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(OptimizerHintKind.KeepPlan, "KEEP", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(OptimizerHintKind.KeepFixedPlan, "KEEPFIXED", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(OptimizerHintKind.CheckConstraintsPlan, "CHECKCONSTRAINTS", SqlVersionFlags.TSql90AndAbove);
		}

		// Token: 0x04000C69 RID: 3177
		internal static readonly PlanOptimizerHintHelper Instance = new PlanOptimizerHintHelper();
	}
}
