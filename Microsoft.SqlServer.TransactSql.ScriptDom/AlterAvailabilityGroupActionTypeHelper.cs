using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200003C RID: 60
	internal class AlterAvailabilityGroupActionTypeHelper : OptionsHelper<AlterAvailabilityGroupActionType>
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00005DE0 File Offset: 0x00003FE0
		private AlterAvailabilityGroupActionTypeHelper()
		{
			base.AddOptionMapping(AlterAvailabilityGroupActionType.Failover, "FAILOVER");
			base.AddOptionMapping(AlterAvailabilityGroupActionType.ForceFailoverAllowDataLoss, "FORCE_FAILOVER_ALLOW_DATA_LOSS");
			base.AddOptionMapping(AlterAvailabilityGroupActionType.Join, TSqlTokenType.Join);
			base.AddOptionMapping(AlterAvailabilityGroupActionType.Offline, "OFFLINE");
			base.AddOptionMapping(AlterAvailabilityGroupActionType.Online, "ONLINE");
		}

		// Token: 0x040000E5 RID: 229
		public static readonly AlterAvailabilityGroupActionTypeHelper Instance = new AlterAvailabilityGroupActionTypeHelper();
	}
}
