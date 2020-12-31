using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000AD RID: 173
	[Flags]
	public enum EndpointProtocolOptions
	{
		// Token: 0x04000956 RID: 2390
		None = 0,
		// Token: 0x04000957 RID: 2391
		HttpAuthenticationRealm = 1,
		// Token: 0x04000958 RID: 2392
		HttpAuthentication = 2,
		// Token: 0x04000959 RID: 2393
		HttpClearPort = 4,
		// Token: 0x0400095A RID: 2394
		HttpCompression = 8,
		// Token: 0x0400095B RID: 2395
		HttpDefaultLogonDomain = 16,
		// Token: 0x0400095C RID: 2396
		HttpPath = 32,
		// Token: 0x0400095D RID: 2397
		HttpPorts = 64,
		// Token: 0x0400095E RID: 2398
		HttpSite = 128,
		// Token: 0x0400095F RID: 2399
		HttpSslPort = 256,
		// Token: 0x04000960 RID: 2400
		HttpOptions = 511,
		// Token: 0x04000961 RID: 2401
		TcpListenerIP = 512,
		// Token: 0x04000962 RID: 2402
		TcpListenerPort = 1024,
		// Token: 0x04000963 RID: 2403
		TcpOptions = 1536
	}
}
