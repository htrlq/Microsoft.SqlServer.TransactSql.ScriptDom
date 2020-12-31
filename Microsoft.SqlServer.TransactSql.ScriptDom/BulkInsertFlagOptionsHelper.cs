using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000074 RID: 116
	internal class BulkInsertFlagOptionsHelper : OptionsHelper<BulkInsertOptionKind>
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x00006C80 File Offset: 0x00004E80
		private BulkInsertFlagOptionsHelper()
		{
			base.AddOptionMapping(BulkInsertOptionKind.NoTriggers, "NO_TRIGGERS");
			base.AddOptionMapping(BulkInsertOptionKind.KeepIdentity, "KEEPIDENTITY");
			base.AddOptionMapping(BulkInsertOptionKind.KeepNulls, "KEEPNULLS");
			base.AddOptionMapping(BulkInsertOptionKind.TabLock, "TABLOCK");
			base.AddOptionMapping(BulkInsertOptionKind.CheckConstraints, "CHECK_CONSTRAINTS");
			base.AddOptionMapping(BulkInsertOptionKind.FireTriggers, "FIRE_TRIGGERS");
		}

		// Token: 0x04000228 RID: 552
		internal static readonly BulkInsertFlagOptionsHelper Instance = new BulkInsertFlagOptionsHelper();
	}
}
