using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000092 RID: 146
	internal class DataCompressionLevelHelper : OptionsHelper<DataCompressionLevel>
	{
		// Token: 0x06000212 RID: 530 RVA: 0x00007514 File Offset: 0x00005714
		private DataCompressionLevelHelper()
		{
			base.AddOptionMapping(DataCompressionLevel.None, "NONE");
			base.AddOptionMapping(DataCompressionLevel.Page, "PAGE");
			base.AddOptionMapping(DataCompressionLevel.Row, "ROW");
			base.AddOptionMapping(DataCompressionLevel.ColumnStore, "COLUMNSTORE");
			base.AddOptionMapping(DataCompressionLevel.ColumnStoreArchive, "COLUMNSTORE_ARCHIVE");
		}

		// Token: 0x0400087E RID: 2174
		public static readonly DataCompressionLevelHelper Instance = new DataCompressionLevelHelper();
	}
}
