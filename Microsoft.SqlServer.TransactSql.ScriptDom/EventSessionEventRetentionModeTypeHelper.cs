using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000B8 RID: 184
	internal class EventSessionEventRetentionModeTypeHelper : OptionsHelper<EventSessionEventRetentionModeType>
	{
		// Token: 0x06000230 RID: 560 RVA: 0x00007FC6 File Offset: 0x000061C6
		private EventSessionEventRetentionModeTypeHelper()
		{
			base.AddOptionMapping(EventSessionEventRetentionModeType.AllowMultipleEventLoss, "ALLOW_MULTIPLE_EVENT_LOSS");
			base.AddOptionMapping(EventSessionEventRetentionModeType.AllowSingleEventLoss, "ALLOW_SINGLE_EVENT_LOSS");
			base.AddOptionMapping(EventSessionEventRetentionModeType.NoEventLoss, "NO_EVENT_LOSS");
		}

		// Token: 0x04000B01 RID: 2817
		internal static readonly EventSessionEventRetentionModeTypeHelper Instance = new EventSessionEventRetentionModeTypeHelper();
	}
}
