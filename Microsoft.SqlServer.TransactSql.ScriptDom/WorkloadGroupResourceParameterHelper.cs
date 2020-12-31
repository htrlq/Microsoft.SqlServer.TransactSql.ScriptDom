using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200018D RID: 397
	[Serializable]
	internal class WorkloadGroupResourceParameterHelper : OptionsHelper<WorkloadGroupParameterType>
	{
		// Token: 0x06000B49 RID: 2889 RVA: 0x0001FA50 File Offset: 0x0001DC50
		private WorkloadGroupResourceParameterHelper()
		{
			base.AddOptionMapping(WorkloadGroupParameterType.RequestMaxMemoryGrantPercent, "REQUEST_MAX_MEMORY_GRANT_PERCENT");
			base.AddOptionMapping(WorkloadGroupParameterType.RequestMaxCpuTimeSec, "REQUEST_MAX_CPU_TIME_SEC");
			base.AddOptionMapping(WorkloadGroupParameterType.RequestMemoryGrantTimeoutSec, "REQUEST_MEMORY_GRANT_TIMEOUT_SEC");
			base.AddOptionMapping(WorkloadGroupParameterType.MaxDop, "MAX_DOP");
			base.AddOptionMapping(WorkloadGroupParameterType.GroupMaxRequests, "GROUP_MAX_REQUESTS");
			base.AddOptionMapping(WorkloadGroupParameterType.GroupMinMemoryPercent, "GROUP_MIN_MEMORY_PERCENT", SqlVersionFlags.TSql110AndAbove);
		}

		// Token: 0x04000FB4 RID: 4020
		internal static readonly WorkloadGroupResourceParameterHelper Instance = new WorkloadGroupResourceParameterHelper();
	}
}
