using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000145 RID: 325
	public enum SimpleAlterFullTextIndexActionKind
	{
		// Token: 0x04000D87 RID: 3463
		None,
		// Token: 0x04000D88 RID: 3464
		Enable,
		// Token: 0x04000D89 RID: 3465
		Disable,
		// Token: 0x04000D8A RID: 3466
		SetChangeTrackingManual,
		// Token: 0x04000D8B RID: 3467
		SetChangeTrackingAuto,
		// Token: 0x04000D8C RID: 3468
		SetChangeTrackingOff,
		// Token: 0x04000D8D RID: 3469
		StartFullPopulation,
		// Token: 0x04000D8E RID: 3470
		StartIncrementalPopulation,
		// Token: 0x04000D8F RID: 3471
		StartUpdatePopulation,
		// Token: 0x04000D90 RID: 3472
		StopPopulation,
		// Token: 0x04000D91 RID: 3473
		PausePopulation,
		// Token: 0x04000D92 RID: 3474
		ResumePopulation
	}
}
