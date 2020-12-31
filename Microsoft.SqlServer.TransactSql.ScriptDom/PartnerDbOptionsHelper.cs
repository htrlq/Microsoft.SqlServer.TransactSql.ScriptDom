using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200010C RID: 268
	internal class PartnerDbOptionsHelper : OptionsHelper<PartnerDatabaseOptionKind>
	{
		// Token: 0x060002BF RID: 703 RVA: 0x00008D68 File Offset: 0x00006F68
		private PartnerDbOptionsHelper()
		{
			base.AddOptionMapping(PartnerDatabaseOptionKind.Failover, "FAILOVER");
			base.AddOptionMapping(PartnerDatabaseOptionKind.ForceServiceAllowDataLoss, "FORCE_SERVICE_ALLOW_DATA_LOSS");
			base.AddOptionMapping(PartnerDatabaseOptionKind.Off, TSqlTokenType.Off);
			base.AddOptionMapping(PartnerDatabaseOptionKind.Resume, "RESUME");
			base.AddOptionMapping(PartnerDatabaseOptionKind.Suspend, "SUSPEND");
			base.AddOptionMapping(PartnerDatabaseOptionKind.Timeout, "TIMEOUT");
		}

		// Token: 0x04000C4B RID: 3147
		public static readonly PartnerDbOptionsHelper Instance = new PartnerDbOptionsHelper();
	}
}
