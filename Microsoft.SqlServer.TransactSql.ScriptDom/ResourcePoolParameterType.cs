using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000129 RID: 297
	[Serializable]
	public enum ResourcePoolParameterType
	{
		// Token: 0x04000CBC RID: 3260
		Unknown,
		// Token: 0x04000CBD RID: 3261
		MaxCpuPercent,
		// Token: 0x04000CBE RID: 3262
		MaxMemoryPercent,
		// Token: 0x04000CBF RID: 3263
		MinCpuPercent,
		// Token: 0x04000CC0 RID: 3264
		MinMemoryPercent,
		// Token: 0x04000CC1 RID: 3265
		CapCpuPercent,
		// Token: 0x04000CC2 RID: 3266
		TargetMemoryPercent,
		// Token: 0x04000CC3 RID: 3267
		MinIoPercent,
		// Token: 0x04000CC4 RID: 3268
		MaxIoPercent,
		// Token: 0x04000CC5 RID: 3269
		CapIoPercent,
		// Token: 0x04000CC6 RID: 3270
		Affinity,
		// Token: 0x04000CC7 RID: 3271
		MinIopsPerVolume,
		// Token: 0x04000CC8 RID: 3272
		MaxIopsPerVolume
	}
}
