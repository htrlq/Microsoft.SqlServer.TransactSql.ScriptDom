using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000071 RID: 113
	[Serializable]
	internal class BrokerPriorityParameterHelper : OptionsHelper<BrokerPriorityParameterType>
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x00006C3B File Offset: 0x00004E3B
		private BrokerPriorityParameterHelper()
		{
			base.AddOptionMapping(BrokerPriorityParameterType.ContractName, "CONTRACT_NAME");
			base.AddOptionMapping(BrokerPriorityParameterType.LocalServiceName, "LOCAL_SERVICE_NAME");
			base.AddOptionMapping(BrokerPriorityParameterType.PriorityLevel, "PRIORITY_LEVEL");
			base.AddOptionMapping(BrokerPriorityParameterType.RemoteServiceName, "REMOTE_SERVICE_NAME");
		}

		// Token: 0x0400021D RID: 541
		internal static readonly BrokerPriorityParameterHelper Instance = new BrokerPriorityParameterHelper();
	}
}
