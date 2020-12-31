using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000AE RID: 174
	internal class EndpointProtocolOptionsHelper : OptionsHelper<EndpointProtocolOptions>
	{
		// Token: 0x06000228 RID: 552 RVA: 0x00007E68 File Offset: 0x00006068
		private EndpointProtocolOptionsHelper()
		{
			base.AddOptionMapping(EndpointProtocolOptions.HttpAuthenticationRealm, "AUTH_REALM");
			base.AddOptionMapping(EndpointProtocolOptions.HttpAuthentication, "AUTHENTICATION");
			base.AddOptionMapping(EndpointProtocolOptions.HttpClearPort, "CLEAR_PORT");
			base.AddOptionMapping(EndpointProtocolOptions.HttpCompression, "COMPRESSION");
			base.AddOptionMapping(EndpointProtocolOptions.HttpDefaultLogonDomain, "DEFAULT_LOGON_DOMAIN");
			base.AddOptionMapping(EndpointProtocolOptions.HttpPath, "PATH");
			base.AddOptionMapping(EndpointProtocolOptions.HttpPorts, "PORTS");
			base.AddOptionMapping(EndpointProtocolOptions.HttpSite, "SITE");
			base.AddOptionMapping(EndpointProtocolOptions.HttpSslPort, "SSL_PORT");
			base.AddOptionMapping(EndpointProtocolOptions.TcpListenerIP, "LISTENER_IP");
			base.AddOptionMapping(EndpointProtocolOptions.TcpListenerPort, "LISTENER_PORT");
		}

		// Token: 0x04000964 RID: 2404
		internal static readonly EndpointProtocolOptionsHelper Instance = new EndpointProtocolOptionsHelper();
	}
}
