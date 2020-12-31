using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000B3 RID: 179
	internal class EndpointTypesHelper : OptionsHelper<EndpointType>
	{
		// Token: 0x0600022E RID: 558 RVA: 0x00007F82 File Offset: 0x00006182
		private EndpointTypesHelper()
		{
			base.AddOptionMapping(EndpointType.DatabaseMirroring, "DATABASE_MIRRORING");
			base.AddOptionMapping(EndpointType.Soap, "SOAP");
			base.AddOptionMapping(EndpointType.ServiceBroker, "SERVICE_BROKER");
			base.AddOptionMapping(EndpointType.TSql, "TSQL");
		}

		// Token: 0x04000972 RID: 2418
		internal static readonly EndpointTypesHelper Instance = new EndpointTypesHelper();
	}
}
