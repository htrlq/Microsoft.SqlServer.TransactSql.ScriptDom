using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200012C RID: 300
	[Serializable]
	internal class RestoreOptionWithValueHelper : OptionsHelper<RestoreOptionKind>
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x0000946C File Offset: 0x0000766C
		private RestoreOptionWithValueHelper()
		{
			base.AddOptionMapping(RestoreOptionKind.File, TSqlTokenType.File);
			base.AddOptionMapping(RestoreOptionKind.Stats, "STATS");
			base.AddOptionMapping(RestoreOptionKind.StopAt, "STOPAT");
			base.AddOptionMapping(RestoreOptionKind.MediaName, "MEDIANAME");
			base.AddOptionMapping(RestoreOptionKind.MediaPassword, "MEDIAPASSWORD");
			base.AddOptionMapping(RestoreOptionKind.Password, "PASSWORD");
			base.AddOptionMapping(RestoreOptionKind.BlockSize, "BLOCKSIZE");
			base.AddOptionMapping(RestoreOptionKind.BufferCount, "BUFFERCOUNT");
			base.AddOptionMapping(RestoreOptionKind.MaxTransferSize, "MAXTRANSFERSIZE");
			base.AddOptionMapping(RestoreOptionKind.Standby, "STANDBY");
			base.AddOptionMapping(RestoreOptionKind.EnhancedIntegrity, "ENHANCEDINTEGRITY");
			base.AddOptionMapping(RestoreOptionKind.SnapshotRestorePhase, "SNAPSHOTRESTOREPHASE");
		}

		// Token: 0x04000CF4 RID: 3316
		internal static readonly RestoreOptionWithValueHelper Instance = new RestoreOptionWithValueHelper();
	}
}
