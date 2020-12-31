using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000124 RID: 292
	[Serializable]
	internal class RecoveryDbOptionsHelper : OptionsHelper<RecoveryDatabaseOptionKind>
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x000091CB File Offset: 0x000073CB
		private RecoveryDbOptionsHelper()
		{
			base.AddOptionMapping(RecoveryDatabaseOptionKind.Full, "FULL");
			base.AddOptionMapping(RecoveryDatabaseOptionKind.BulkLogged, "BULK_LOGGED");
			base.AddOptionMapping(RecoveryDatabaseOptionKind.Simple, "SIMPLE");
		}

		// Token: 0x04000CB1 RID: 3249
		internal static readonly RecoveryDbOptionsHelper Instance = new RecoveryDbOptionsHelper();
	}
}
