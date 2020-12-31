using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000AF RID: 175
	internal class EndpointProtocolsHelper : OptionsHelper<EndpointProtocol>
	{
		// Token: 0x0600022A RID: 554 RVA: 0x00007F1E File Offset: 0x0000611E
		private EndpointProtocolsHelper()
		{
			base.AddOptionMapping(EndpointProtocol.Tcp, "TCP");
			base.AddOptionMapping(EndpointProtocol.Http, "HTTP");
		}

		// Token: 0x04000965 RID: 2405
		internal static readonly EndpointProtocolsHelper Instance = new EndpointProtocolsHelper();
	}
}
