using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000100 RID: 256
	internal class OnOffSimpleDbOptionsHelper : OptionsHelper<DatabaseOptionKind>
	{
		// Token: 0x060002B2 RID: 690 RVA: 0x00008AB4 File Offset: 0x00006CB4
		private OnOffSimpleDbOptionsHelper()
		{
			base.AddOptionMapping(DatabaseOptionKind.CursorCloseOnCommit, "CURSOR_CLOSE_ON_COMMIT", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.AutoClose, "AUTO_CLOSE", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.AutoCreateStatistics, "AUTO_CREATE_STATISTICS", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.AutoShrink, "AUTO_SHRINK", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.AutoUpdateStatistics, "AUTO_UPDATE_STATISTICS", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.AnsiNullDefault, "ANSI_NULL_DEFAULT", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.AnsiNulls, "ANSI_NULLS", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.AnsiPadding, "ANSI_PADDING", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.AnsiWarnings, "ANSI_WARNINGS", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.ArithAbort, "ARITHABORT", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.ConcatNullYieldsNull, "CONCAT_NULL_YIELDS_NULL", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.NumericRoundAbort, "NUMERIC_ROUNDABORT", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.QuotedIdentifier, "QUOTED_IDENTIFIER", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.RecursiveTriggers, "RECURSIVE_TRIGGERS", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.TornPageDetection, "TORN_PAGE_DETECTION", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.DBChaining, "DB_CHAINING", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.Trustworthy, "TRUSTWORTHY", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.AutoUpdateStatisticsAsync, "AUTO_UPDATE_STATISTICS_ASYNC", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.DateCorrelationOptimization, "DATE_CORRELATION_OPTIMIZATION", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.AllowSnapshotIsolation, "ALLOW_SNAPSHOT_ISOLATION", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.ReadCommittedSnapshot, "READ_COMMITTED_SNAPSHOT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.SupplementalLogging, "SUPPLEMENTAL_LOGGING", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.Encryption, "ENCRYPTION", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.HonorBrokerPriority, "HONOR_BROKER_PRIORITY", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.VarDecimalStorageFormat, "VARDECIMAL_STORAGE_FORMAT", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.NestedTriggers, "NESTED_TRIGGERS", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.TransformNoiseWords, "TRANSFORM_NOISE_WORDS", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.MemoryOptimizedElevateToSnapshot, "MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT", SqlVersionFlags.TSql120);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00008C6C File Offset: 0x00006E6C
		internal bool RequiresEqualsSign(DatabaseOptionKind optionKind)
		{
			switch (optionKind)
			{
			case DatabaseOptionKind.NestedTriggers:
			case DatabaseOptionKind.TransformNoiseWords:
				break;
			default:
				if (optionKind != DatabaseOptionKind.MemoryOptimizedElevateToSnapshot)
				{
					return false;
				}
				break;
			}
			return true;
		}

		// Token: 0x04000BFD RID: 3069
		internal static readonly OnOffSimpleDbOptionsHelper Instance = new OnOffSimpleDbOptionsHelper();
	}
}
