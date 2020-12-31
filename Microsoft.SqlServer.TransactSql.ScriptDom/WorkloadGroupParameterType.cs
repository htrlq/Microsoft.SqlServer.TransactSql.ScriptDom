using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200018C RID: 396
	[Serializable]
	public enum WorkloadGroupParameterType
	{
		// Token: 0x04000FAD RID: 4013
		Importance,
		// Token: 0x04000FAE RID: 4014
		RequestMaxMemoryGrantPercent,
		// Token: 0x04000FAF RID: 4015
		RequestMaxCpuTimeSec,
		// Token: 0x04000FB0 RID: 4016
		RequestMemoryGrantTimeoutSec,
		// Token: 0x04000FB1 RID: 4017
		MaxDop,
		// Token: 0x04000FB2 RID: 4018
		GroupMaxRequests,
		// Token: 0x04000FB3 RID: 4019
		GroupMinMemoryPercent
	}
}
