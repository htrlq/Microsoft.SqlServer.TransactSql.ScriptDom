using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000189 RID: 393
	[Serializable]
	internal class WaitForOptionHelper : OptionsHelper<WaitForOption>
	{
		// Token: 0x06000B47 RID: 2887 RVA: 0x0001FA23 File Offset: 0x0001DC23
		private WaitForOptionHelper()
		{
			base.AddOptionMapping(WaitForOption.Delay, "DELAY");
			base.AddOptionMapping(WaitForOption.Time, "TIME");
		}

		// Token: 0x04000FA2 RID: 4002
		internal static readonly WaitForOptionHelper Instance = new WaitForOptionHelper();
	}
}
