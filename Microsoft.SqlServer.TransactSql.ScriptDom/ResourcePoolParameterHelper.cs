using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000128 RID: 296
	[Serializable]
	internal class ResourcePoolParameterHelper : OptionsHelper<ResourcePoolParameterType>
	{
		// Token: 0x060002DC RID: 732 RVA: 0x00009230 File Offset: 0x00007430
		private ResourcePoolParameterHelper()
		{
			base.AddOptionMapping(ResourcePoolParameterType.MaxCpuPercent, "MAX_CPU_PERCENT");
			base.AddOptionMapping(ResourcePoolParameterType.MaxMemoryPercent, "MAX_MEMORY_PERCENT");
			base.AddOptionMapping(ResourcePoolParameterType.MinCpuPercent, "MIN_CPU_PERCENT");
			base.AddOptionMapping(ResourcePoolParameterType.MinMemoryPercent, "MIN_MEMORY_PERCENT");
			base.AddOptionMapping(ResourcePoolParameterType.CapCpuPercent, "CAP_CPU_PERCENT", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(ResourcePoolParameterType.TargetMemoryPercent, "TARGET_MEMORY_PERCENT", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(ResourcePoolParameterType.MinIoPercent, "MIN_IO_PERCENT", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(ResourcePoolParameterType.MaxIoPercent, "MAX_IO_PERCENT", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(ResourcePoolParameterType.CapIoPercent, "CAP_IO_PERCENT", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(ResourcePoolParameterType.Affinity, "AFFINITY", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(ResourcePoolParameterType.MinIopsPerVolume, "MIN_IOPS_PER_VOLUME", SqlVersionFlags.TSql120);
			base.AddOptionMapping(ResourcePoolParameterType.MaxIopsPerVolume, "MAX_IOPS_PER_VOLUME", SqlVersionFlags.TSql120);
		}

		// Token: 0x04000CBA RID: 3258
		internal static readonly ResourcePoolParameterHelper Instance = new ResourcePoolParameterHelper();
	}
}
