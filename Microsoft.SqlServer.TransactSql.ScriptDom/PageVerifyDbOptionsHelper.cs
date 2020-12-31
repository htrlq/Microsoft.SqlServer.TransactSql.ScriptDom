using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000105 RID: 261
	internal class PageVerifyDbOptionsHelper : OptionsHelper<PageVerifyDatabaseOptionKind>
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x00008CDB File Offset: 0x00006EDB
		private PageVerifyDbOptionsHelper()
		{
			base.AddOptionMapping(PageVerifyDatabaseOptionKind.None, "NONE");
			base.AddOptionMapping(PageVerifyDatabaseOptionKind.Checksum, "CHECKSUM");
			base.AddOptionMapping(PageVerifyDatabaseOptionKind.TornPageDetection, "TORN_PAGE_DETECTION");
		}

		// Token: 0x04000C28 RID: 3112
		internal static readonly PageVerifyDbOptionsHelper Instance = new PageVerifyDbOptionsHelper();
	}
}
