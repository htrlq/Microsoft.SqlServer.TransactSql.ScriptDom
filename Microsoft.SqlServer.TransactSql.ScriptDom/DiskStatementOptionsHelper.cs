using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200009F RID: 159
	internal class DiskStatementOptionsHelper : OptionsHelper<DiskStatementOptionKind>
	{
		// Token: 0x0600021E RID: 542 RVA: 0x00007CBC File Offset: 0x00005EBC
		private DiskStatementOptionsHelper()
		{
			base.AddOptionMapping(DiskStatementOptionKind.Name, "NAME");
			base.AddOptionMapping(DiskStatementOptionKind.PhysName, "PHYSNAME");
			base.AddOptionMapping(DiskStatementOptionKind.VDevNo, "VDEVNO");
			base.AddOptionMapping(DiskStatementOptionKind.Size, "SIZE");
			base.AddOptionMapping(DiskStatementOptionKind.VStart, "VSTART");
		}

		// Token: 0x04000922 RID: 2338
		internal static readonly DiskStatementOptionsHelper Instance = new DiskStatementOptionsHelper();
	}
}
