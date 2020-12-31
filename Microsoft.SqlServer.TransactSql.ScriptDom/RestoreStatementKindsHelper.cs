using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200012E RID: 302
	[Serializable]
	internal class RestoreStatementKindsHelper : OptionsHelper<RestoreStatementKind>
	{
		// Token: 0x060002E2 RID: 738 RVA: 0x00009524 File Offset: 0x00007724
		private RestoreStatementKindsHelper()
		{
			base.AddOptionMapping(RestoreStatementKind.FileListOnly, "FILELISTONLY");
			base.AddOptionMapping(RestoreStatementKind.VerifyOnly, "VERIFYONLY");
			base.AddOptionMapping(RestoreStatementKind.LabelOnly, "LABELONLY");
			base.AddOptionMapping(RestoreStatementKind.RewindOnly, "REWINDONLY");
			base.AddOptionMapping(RestoreStatementKind.HeaderOnly, "HEADERONLY");
		}

		// Token: 0x04000CFE RID: 3326
		internal static readonly RestoreStatementKindsHelper Instance = new RestoreStatementKindsHelper();
	}
}
