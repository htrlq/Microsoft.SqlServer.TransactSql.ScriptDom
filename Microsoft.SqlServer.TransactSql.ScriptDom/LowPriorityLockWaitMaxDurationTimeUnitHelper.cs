using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000F3 RID: 243
	[Serializable]
	internal class LowPriorityLockWaitMaxDurationTimeUnitHelper : OptionsHelper<TimeUnit>
	{
		// Token: 0x060002AA RID: 682 RVA: 0x000089AF File Offset: 0x00006BAF
		private LowPriorityLockWaitMaxDurationTimeUnitHelper()
		{
			base.AddOptionMapping(TimeUnit.Minutes, "MINUTES");
		}

		// Token: 0x04000BC8 RID: 3016
		internal static readonly LowPriorityLockWaitMaxDurationTimeUnitHelper Instance = new LowPriorityLockWaitMaxDurationTimeUnitHelper();
	}
}
