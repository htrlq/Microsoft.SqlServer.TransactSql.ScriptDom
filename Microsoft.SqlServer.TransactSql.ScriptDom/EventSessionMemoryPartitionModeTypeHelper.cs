using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000BA RID: 186
	internal class EventSessionMemoryPartitionModeTypeHelper : OptionsHelper<EventSessionMemoryPartitionModeType>
	{
		// Token: 0x06000232 RID: 562 RVA: 0x00007FFE File Offset: 0x000061FE
		private EventSessionMemoryPartitionModeTypeHelper()
		{
			base.AddOptionMapping(EventSessionMemoryPartitionModeType.None, "NONE");
			base.AddOptionMapping(EventSessionMemoryPartitionModeType.PerCpu, "PER_CPU");
			base.AddOptionMapping(EventSessionMemoryPartitionModeType.PerNode, "PER_NODE");
		}

		// Token: 0x04000B07 RID: 2823
		internal static readonly EventSessionMemoryPartitionModeTypeHelper Instance = new EventSessionMemoryPartitionModeTypeHelper();
	}
}
