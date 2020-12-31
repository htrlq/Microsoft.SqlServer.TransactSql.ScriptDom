using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000132 RID: 306
	[Serializable]
	internal class RouteOptionHelper : OptionsHelper<RouteOptionKind>
	{
		// Token: 0x060002E6 RID: 742 RVA: 0x000095B8 File Offset: 0x000077B8
		private RouteOptionHelper()
		{
			base.AddOptionMapping(RouteOptionKind.Address, "ADDRESS");
			base.AddOptionMapping(RouteOptionKind.BrokerInstance, "BROKER_INSTANCE");
			base.AddOptionMapping(RouteOptionKind.Lifetime, "LIFETIME");
			base.AddOptionMapping(RouteOptionKind.MirrorAddress, "MIRROR_ADDRESS");
			base.AddOptionMapping(RouteOptionKind.ServiceName, "SERVICE_NAME");
		}

		// Token: 0x04000D09 RID: 3337
		internal static readonly RouteOptionHelper Instance = new RouteOptionHelper();
	}
}
