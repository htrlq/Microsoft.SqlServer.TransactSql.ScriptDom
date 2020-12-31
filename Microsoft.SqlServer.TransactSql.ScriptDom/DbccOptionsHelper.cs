using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000097 RID: 151
	internal class DbccOptionsHelper : OptionsHelper<DbccOptionKind>
	{
		// Token: 0x06000218 RID: 536 RVA: 0x00007B30 File Offset: 0x00005D30
		private DbccOptionsHelper()
		{
			base.AddOptionMapping(DbccOptionKind.AllErrorMessages, "ALL_ERRORMSGS");
			base.AddOptionMapping(DbccOptionKind.CountRows, "COUNT_ROWS");
			base.AddOptionMapping(DbccOptionKind.NoInfoMessages, "NO_INFOMSGS");
			base.AddOptionMapping(DbccOptionKind.TableResults, "TABLERESULTS");
			base.AddOptionMapping(DbccOptionKind.TabLock, "TABLOCK");
			base.AddOptionMapping(DbccOptionKind.StatHeader, "STAT_HEADER");
			base.AddOptionMapping(DbccOptionKind.DensityVector, "DENSITY_VECTOR");
			base.AddOptionMapping(DbccOptionKind.HistogramSteps, "HISTOGRAM_STEPS");
			base.AddOptionMapping(DbccOptionKind.EstimateOnly, "ESTIMATEONLY");
			base.AddOptionMapping(DbccOptionKind.Fast, "FAST");
			base.AddOptionMapping(DbccOptionKind.AllLevels, "ALL_LEVELS");
			base.AddOptionMapping(DbccOptionKind.AllIndexes, "ALL_INDEXES");
			base.AddOptionMapping(DbccOptionKind.PhysicalOnly, "PHYSICAL_ONLY");
			base.AddOptionMapping(DbccOptionKind.AllConstraints, "ALL_CONSTRAINTS");
			base.AddOptionMapping(DbccOptionKind.StatsStream, "STATS_STREAM");
			base.AddOptionMapping(DbccOptionKind.Histogram, "HISTOGRAM");
			base.AddOptionMapping(DbccOptionKind.DataPurity, "DATA_PURITY");
			base.AddOptionMapping(DbccOptionKind.MarkInUseForRemoval, "MARK_IN_USE_FOR_REMOVAL");
			base.AddOptionMapping(DbccOptionKind.ExtendedLogicalChecks, "EXTENDED_LOGICAL_CHECKS", SqlVersionFlags.TSql100AndAbove);
		}

		// Token: 0x04000904 RID: 2308
		internal static readonly DbccOptionsHelper Instance = new DbccOptionsHelper();
	}
}
