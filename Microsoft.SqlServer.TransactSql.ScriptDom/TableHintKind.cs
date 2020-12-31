using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000156 RID: 342
	[Serializable]
	public enum TableHintKind
	{
		// Token: 0x04000E01 RID: 3585
		None,
		// Token: 0x04000E02 RID: 3586
		FastFirstRow,
		// Token: 0x04000E03 RID: 3587
		HoldLock,
		// Token: 0x04000E04 RID: 3588
		NoLock,
		// Token: 0x04000E05 RID: 3589
		PagLock,
		// Token: 0x04000E06 RID: 3590
		ReadCommitted,
		// Token: 0x04000E07 RID: 3591
		ReadPast,
		// Token: 0x04000E08 RID: 3592
		ReadUncommitted,
		// Token: 0x04000E09 RID: 3593
		RepeatableRead,
		// Token: 0x04000E0A RID: 3594
		Rowlock,
		// Token: 0x04000E0B RID: 3595
		Serializable,
		// Token: 0x04000E0C RID: 3596
		TabLock,
		// Token: 0x04000E0D RID: 3597
		TabLockX,
		// Token: 0x04000E0E RID: 3598
		UpdLock,
		// Token: 0x04000E0F RID: 3599
		XLock,
		// Token: 0x04000E10 RID: 3600
		NoExpand,
		// Token: 0x04000E11 RID: 3601
		NoWait,
		// Token: 0x04000E12 RID: 3602
		ReadCommittedLock,
		// Token: 0x04000E13 RID: 3603
		KeepIdentity,
		// Token: 0x04000E14 RID: 3604
		KeepDefaults,
		// Token: 0x04000E15 RID: 3605
		IgnoreConstraints,
		// Token: 0x04000E16 RID: 3606
		IgnoreTriggers,
		// Token: 0x04000E17 RID: 3607
		ForceSeek,
		// Token: 0x04000E18 RID: 3608
		Index,
		// Token: 0x04000E19 RID: 3609
		SpatialWindowMaxCells,
		// Token: 0x04000E1A RID: 3610
		ForceScan,
		// Token: 0x04000E1B RID: 3611
		Snapshot
	}
}
