using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200013D RID: 317
	internal class ServiceBrokerOptionsHelper : OptionsHelper<ServiceBrokerOption>
	{
		// Token: 0x060002EE RID: 750 RVA: 0x000098A1 File Offset: 0x00007AA1
		private ServiceBrokerOptionsHelper()
		{
			base.AddOptionMapping(ServiceBrokerOption.NewBroker, "NEW_BROKER");
			base.AddOptionMapping(ServiceBrokerOption.EnableBroker, "ENABLE_BROKER");
			base.AddOptionMapping(ServiceBrokerOption.ErrorBrokerConversations, "ERROR_BROKER_CONVERSATIONS");
		}

		// Token: 0x04000D4A RID: 3402
		internal static readonly ServiceBrokerOptionsHelper Instance = new ServiceBrokerOptionsHelper();
	}
}
