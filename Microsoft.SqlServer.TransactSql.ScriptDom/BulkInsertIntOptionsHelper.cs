using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000075 RID: 117
	internal class BulkInsertIntOptionsHelper : OptionsHelper<BulkInsertOptionKind>
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x00006CEC File Offset: 0x00004EEC
		private BulkInsertIntOptionsHelper()
		{
			base.AddOptionMapping(BulkInsertOptionKind.MaxErrors, "MAXERRORS");
			base.AddOptionMapping(BulkInsertOptionKind.FirstRow, "FIRSTROW");
			base.AddOptionMapping(BulkInsertOptionKind.LastRow, "LASTROW");
			base.AddOptionMapping(BulkInsertOptionKind.BatchSize, "BATCHSIZE");
			base.AddOptionMapping(BulkInsertOptionKind.CodePage, "CODEPAGE");
			base.AddOptionMapping(BulkInsertOptionKind.RowsPerBatch, "ROWS_PER_BATCH");
			base.AddOptionMapping(BulkInsertOptionKind.KilobytesPerBatch, "KILOBYTES_PER_BATCH");
		}

		// Token: 0x04000229 RID: 553
		internal static readonly BulkInsertIntOptionsHelper Instance = new BulkInsertIntOptionsHelper();
	}
}
