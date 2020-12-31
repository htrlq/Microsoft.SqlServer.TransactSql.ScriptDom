using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000101 RID: 257
	internal class OpenRowsetBulkHintOptionsHelper : OptionsHelper<BulkInsertOptionKind>
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x00008CA0 File Offset: 0x00006EA0
		private OpenRowsetBulkHintOptionsHelper()
		{
			base.AddOptionMapping(BulkInsertOptionKind.SingleBlob, "SINGLE_BLOB");
			base.AddOptionMapping(BulkInsertOptionKind.SingleClob, "SINGLE_CLOB");
			base.AddOptionMapping(BulkInsertOptionKind.SingleNClob, "SINGLE_NCLOB");
		}

		// Token: 0x04000BFE RID: 3070
		internal static readonly OpenRowsetBulkHintOptionsHelper Instance = new OpenRowsetBulkHintOptionsHelper();
	}
}
