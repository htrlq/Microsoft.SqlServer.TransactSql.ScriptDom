using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000140 RID: 320
	[Flags]
	[Serializable]
	public enum SetOffsets
	{
		// Token: 0x04000D55 RID: 3413
		None = 0,
		// Token: 0x04000D56 RID: 3414
		Select = 1,
		// Token: 0x04000D57 RID: 3415
		From = 2,
		// Token: 0x04000D58 RID: 3416
		Order = 4,
		// Token: 0x04000D59 RID: 3417
		Compute = 8,
		// Token: 0x04000D5A RID: 3418
		Table = 16,
		// Token: 0x04000D5B RID: 3419
		Procedure = 32,
		// Token: 0x04000D5C RID: 3420
		Execute = 64,
		// Token: 0x04000D5D RID: 3421
		Statement = 128,
		// Token: 0x04000D5E RID: 3422
		Param = 256
	}
}
