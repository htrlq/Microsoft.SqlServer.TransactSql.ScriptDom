using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000099 RID: 153
	internal class DelayedDurabilityOptionKindHelper : OptionsHelper<DelayedDurabilityOptionKind>
	{
		// Token: 0x0600021A RID: 538 RVA: 0x00007C3F File Offset: 0x00005E3F
		private DelayedDurabilityOptionKindHelper()
		{
			base.AddOptionMapping(DelayedDurabilityOptionKind.Disabled, "DISABLED");
			base.AddOptionMapping(DelayedDurabilityOptionKind.Allowed, "ALLOWED");
			base.AddOptionMapping(DelayedDurabilityOptionKind.Forced, "FORCED");
		}

		// Token: 0x04000909 RID: 2313
		internal static readonly DelayedDurabilityOptionKindHelper Instance = new DelayedDurabilityOptionKindHelper();
	}
}
