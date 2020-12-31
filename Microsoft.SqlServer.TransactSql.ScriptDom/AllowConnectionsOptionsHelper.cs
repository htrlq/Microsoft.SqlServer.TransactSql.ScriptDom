using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000039 RID: 57
	internal class AllowConnectionsOptionsHelper : OptionsHelper<AllowConnectionsOptionKind>
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x00005D9A File Offset: 0x00003F9A
		private AllowConnectionsOptionsHelper()
		{
			base.AddOptionMapping(AllowConnectionsOptionKind.All, "ALL");
			base.AddOptionMapping(AllowConnectionsOptionKind.No, "NO");
			base.AddOptionMapping(AllowConnectionsOptionKind.ReadOnly, "READ_ONLY");
			base.AddOptionMapping(AllowConnectionsOptionKind.ReadWrite, "READ_WRITE");
		}

		// Token: 0x040000DA RID: 218
		public static readonly AllowConnectionsOptionsHelper Instance = new AllowConnectionsOptionsHelper();
	}
}
