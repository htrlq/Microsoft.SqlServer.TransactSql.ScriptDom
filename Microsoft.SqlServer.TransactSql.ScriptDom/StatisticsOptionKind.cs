using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000152 RID: 338
	[Serializable]
	public enum StatisticsOptionKind
	{
		// Token: 0x04000DE5 RID: 3557
		FullScan,
		// Token: 0x04000DE6 RID: 3558
		SamplePercent,
		// Token: 0x04000DE7 RID: 3559
		SampleRows,
		// Token: 0x04000DE8 RID: 3560
		StatsStream,
		// Token: 0x04000DE9 RID: 3561
		NoRecompute,
		// Token: 0x04000DEA RID: 3562
		Resample,
		// Token: 0x04000DEB RID: 3563
		RowCount,
		// Token: 0x04000DEC RID: 3564
		PageCount,
		// Token: 0x04000DED RID: 3565
		All,
		// Token: 0x04000DEE RID: 3566
		Columns,
		// Token: 0x04000DEF RID: 3567
		Index,
		// Token: 0x04000DF0 RID: 3568
		Rows,
		// Token: 0x04000DF1 RID: 3569
		Incremental
	}
}
