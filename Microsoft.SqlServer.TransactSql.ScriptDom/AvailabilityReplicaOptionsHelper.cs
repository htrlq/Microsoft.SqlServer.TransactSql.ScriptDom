using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000065 RID: 101
	internal class AvailabilityReplicaOptionsHelper : OptionsHelper<AvailabilityReplicaOptionKind>
	{
		// Token: 0x060001CD RID: 461 RVA: 0x00006964 File Offset: 0x00004B64
		private AvailabilityReplicaOptionsHelper()
		{
			base.AddOptionMapping(AvailabilityReplicaOptionKind.ApplyDelay, "APPLY_DELAY");
			base.AddOptionMapping(AvailabilityReplicaOptionKind.AvailabilityMode, "AVAILABILITY_MODE");
			base.AddOptionMapping(AvailabilityReplicaOptionKind.EndpointUrl, "ENDPOINT_URL");
			base.AddOptionMapping(AvailabilityReplicaOptionKind.SecondaryRole, "SECONDARY_ROLE");
			base.AddOptionMapping(AvailabilityReplicaOptionKind.SessionTimeout, "SESSION_TIMEOUT");
		}

		// Token: 0x040001C5 RID: 453
		public static readonly AvailabilityReplicaOptionsHelper Instance = new AvailabilityReplicaOptionsHelper();
	}
}
