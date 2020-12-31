using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000A6 RID: 166
	internal class EnableDisableOptionTypeHelper : OptionsHelper<EnableDisableOptionType>
	{
		// Token: 0x06000222 RID: 546 RVA: 0x00007D43 File Offset: 0x00005F43
		private EnableDisableOptionTypeHelper()
		{
			base.AddOptionMapping(EnableDisableOptionType.Enable, "ENABLE");
			base.AddOptionMapping(EnableDisableOptionType.Disable, "DISABLE");
		}

		// Token: 0x04000936 RID: 2358
		internal static readonly EnableDisableOptionTypeHelper Instance = new EnableDisableOptionTypeHelper();
	}
}
