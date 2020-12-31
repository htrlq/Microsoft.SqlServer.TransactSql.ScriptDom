using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000068 RID: 104
	internal class BackupOptionsWithValueHelper : OptionsHelper<BackupOptionKind>
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x00006B20 File Offset: 0x00004D20
		private BackupOptionsWithValueHelper()
		{
			base.AddOptionMapping(BackupOptionKind.Stats, "STATS");
			base.AddOptionMapping(BackupOptionKind.Standby, "STANDBY");
			base.AddOptionMapping(BackupOptionKind.ExpireDate, "EXPIREDATE");
			base.AddOptionMapping(BackupOptionKind.RetainDays, "RETAINDAYS");
			base.AddOptionMapping(BackupOptionKind.Name, "NAME");
			base.AddOptionMapping(BackupOptionKind.Description, "DESCRIPTION");
			base.AddOptionMapping(BackupOptionKind.Password, "PASSWORD", SqlVersionFlags.TSqlUnder110);
			base.AddOptionMapping(BackupOptionKind.MediaName, "MEDIANAME");
			base.AddOptionMapping(BackupOptionKind.MediaDescription, "MEDIADESCRIPTION");
			base.AddOptionMapping(BackupOptionKind.MediaPassword, "MEDIAPASSWORD", SqlVersionFlags.TSqlUnder110);
			base.AddOptionMapping(BackupOptionKind.BlockSize, "BLOCKSIZE");
			base.AddOptionMapping(BackupOptionKind.BufferCount, "BUFFERCOUNT");
			base.AddOptionMapping(BackupOptionKind.MaxTransferSize, "MAXTRANSFERSIZE");
			base.AddOptionMapping(BackupOptionKind.EnhancedIntegrity, "ENHANCEDINTEGRITY");
		}

		// Token: 0x040001F0 RID: 496
		internal static readonly BackupOptionsWithValueHelper Instance = new BackupOptionsWithValueHelper();
	}
}
