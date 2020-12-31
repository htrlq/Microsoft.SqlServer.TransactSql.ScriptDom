using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200015B RID: 347
	[Serializable]
	internal class TargetRecoveryTimeUnitHelper : OptionsHelper<TimeUnit>
	{
		// Token: 0x06000300 RID: 768 RVA: 0x00009CC7 File Offset: 0x00007EC7
		private TargetRecoveryTimeUnitHelper()
		{
			base.AddOptionMapping(TimeUnit.Minutes, "MINUTES");
			base.AddOptionMapping(TimeUnit.Seconds, "SECONDS");
		}

		// Token: 0x04000E2E RID: 3630
		internal static readonly TargetRecoveryTimeUnitHelper Instance = new TargetRecoveryTimeUnitHelper();
	}
}
