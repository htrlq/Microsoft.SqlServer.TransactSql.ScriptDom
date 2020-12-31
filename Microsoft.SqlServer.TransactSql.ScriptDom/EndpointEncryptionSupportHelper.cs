using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000AB RID: 171
	internal class EndpointEncryptionSupportHelper : OptionsHelper<EndpointEncryptionSupport>
	{
		// Token: 0x06000226 RID: 550 RVA: 0x00007E30 File Offset: 0x00006030
		private EndpointEncryptionSupportHelper()
		{
			base.AddOptionMapping(EndpointEncryptionSupport.Disabled, "DISABLED");
			base.AddOptionMapping(EndpointEncryptionSupport.Required, "REQUIRED");
			base.AddOptionMapping(EndpointEncryptionSupport.Supported, "SUPPORTED");
		}

		// Token: 0x04000950 RID: 2384
		internal static readonly EndpointEncryptionSupportHelper Instance = new EndpointEncryptionSupportHelper();
	}
}
