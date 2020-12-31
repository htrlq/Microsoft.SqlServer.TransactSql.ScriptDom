using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000B1 RID: 177
	internal class EndpointStateHelper : OptionsHelper<EndpointState>
	{
		// Token: 0x0600022C RID: 556 RVA: 0x00007F4A File Offset: 0x0000614A
		private EndpointStateHelper()
		{
			base.AddOptionMapping(EndpointState.Disabled, "DISABLED");
			base.AddOptionMapping(EndpointState.Started, "STARTED");
			base.AddOptionMapping(EndpointState.Stopped, "STOPPED");
		}

		// Token: 0x0400096B RID: 2411
		internal static readonly EndpointStateHelper Instance = new EndpointStateHelper();
	}
}
