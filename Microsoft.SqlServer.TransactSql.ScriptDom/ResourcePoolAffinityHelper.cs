using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000126 RID: 294
	[Serializable]
	internal class ResourcePoolAffinityHelper : OptionsHelper<ResourcePoolAffinityType>
	{
		// Token: 0x060002DA RID: 730 RVA: 0x00009203 File Offset: 0x00007403
		private ResourcePoolAffinityHelper()
		{
			base.AddOptionMapping(ResourcePoolAffinityType.Scheduler, "SCHEDULER");
			base.AddOptionMapping(ResourcePoolAffinityType.NumaNode, "NUMANODE");
		}

		// Token: 0x04000CB5 RID: 3253
		internal static readonly ResourcePoolAffinityHelper Instance = new ResourcePoolAffinityHelper();
	}
}
