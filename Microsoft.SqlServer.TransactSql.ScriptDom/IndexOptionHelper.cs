using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000DD RID: 221
	internal class IndexOptionHelper : OptionsHelper<IndexOptionKind>
	{
		// Token: 0x06000270 RID: 624 RVA: 0x00008628 File Offset: 0x00006828
		private IndexOptionHelper()
		{
			base.AddOptionMapping(IndexOptionKind.PadIndex, "PAD_INDEX", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(IndexOptionKind.FillFactor, TSqlTokenType.FillFactor, SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(IndexOptionKind.SortInTempDB, "SORT_IN_TEMPDB", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(IndexOptionKind.IgnoreDupKey, "IGNORE_DUP_KEY", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(IndexOptionKind.StatisticsNoRecompute, "STATISTICS_NORECOMPUTE", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(IndexOptionKind.DropExisting, "DROP_EXISTING", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(IndexOptionKind.Online, "ONLINE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(IndexOptionKind.AllowPageLocks, "ALLOW_PAGE_LOCKS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(IndexOptionKind.AllowRowLocks, "ALLOW_ROW_LOCKS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(IndexOptionKind.MaxDop, "MAXDOP", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(IndexOptionKind.LobCompaction, "LOB_COMPACTION", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(IndexOptionKind.FileStreamOn, "FILESTREAM_ON", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(IndexOptionKind.DataCompression, "DATA_COMPRESSION", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(IndexOptionKind.BucketCount, "BUCKET_COUNT", SqlVersionFlags.TSql120);
			base.AddOptionMapping(IndexOptionKind.StatisticsIncremental, "STATISTICS_INCREMENTAL", SqlVersionFlags.TSql120);
		}

		// Token: 0x04000B83 RID: 2947
		internal static readonly IndexOptionHelper Instance = new IndexOptionHelper();
	}
}
