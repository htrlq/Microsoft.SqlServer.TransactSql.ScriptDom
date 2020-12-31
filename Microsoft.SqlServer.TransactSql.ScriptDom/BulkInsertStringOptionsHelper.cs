using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000077 RID: 119
	internal class BulkInsertStringOptionsHelper : OptionsHelper<BulkInsertOptionKind>
	{
		// Token: 0x060001DB RID: 475 RVA: 0x00006D64 File Offset: 0x00004F64
		private BulkInsertStringOptionsHelper()
		{
			base.AddOptionMapping(BulkInsertOptionKind.FieldTerminator, "FIELDTERMINATOR");
			base.AddOptionMapping(BulkInsertOptionKind.RowTerminator, "ROWTERMINATOR");
			base.AddOptionMapping(BulkInsertOptionKind.FormatFile, "FORMATFILE");
			base.AddOptionMapping(BulkInsertOptionKind.ErrorFile, "ERRORFILE");
			base.AddOptionMapping(BulkInsertOptionKind.CodePage, "CODEPAGE");
			base.AddOptionMapping(BulkInsertOptionKind.DataFileType, "DATAFILETYPE");
		}

		// Token: 0x04000242 RID: 578
		internal static readonly BulkInsertStringOptionsHelper Instance = new BulkInsertStringOptionsHelper();
	}
}
