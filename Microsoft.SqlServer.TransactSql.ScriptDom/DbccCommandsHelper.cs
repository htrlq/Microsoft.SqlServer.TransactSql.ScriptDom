﻿using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000094 RID: 148
	internal class DbccCommandsHelper : OptionsHelper<DbccCommand>
	{
		// Token: 0x06000214 RID: 532 RVA: 0x00007570 File Offset: 0x00005770
		private DbccCommandsHelper()
		{
			base.AddOptionMapping(DbccCommand.ActiveCursors, "ACTIVECURSORS");
			base.AddOptionMapping(DbccCommand.AddExtendedProc, "ADDEXTENDEDPROC");
			base.AddOptionMapping(DbccCommand.AddInstance, "ADDINSTANCE");
			base.AddOptionMapping(DbccCommand.AuditEvent, "AUDITEVENT");
			base.AddOptionMapping(DbccCommand.AutoPilot, "AUTOPILOT");
			base.AddOptionMapping(DbccCommand.Buffer, "BUFFER");
			base.AddOptionMapping(DbccCommand.Bytes, "BYTES");
			base.AddOptionMapping(DbccCommand.CacheProfile, "CACHEPROFILE");
			base.AddOptionMapping(DbccCommand.CacheStats, "CACHESTATS");
			base.AddOptionMapping(DbccCommand.CallFullText, "CALLFULLTEXT");
			base.AddOptionMapping(DbccCommand.CheckAlloc, "CHECKALLOC");
			base.AddOptionMapping(DbccCommand.CheckCatalog, "CHECKCATALOG");
			base.AddOptionMapping(DbccCommand.CheckConstraints, "CHECK_CONSTRAINTS");
			base.AddOptionMapping(DbccCommand.CheckDB, "CHECKDB");
			base.AddOptionMapping(DbccCommand.CheckFileGroup, "CHECKFILEGROUP");
			base.AddOptionMapping(DbccCommand.CheckIdent, "CHECKIDENT");
			base.AddOptionMapping(DbccCommand.CheckPrimaryFile, "CHECKPRIMARYFILE");
			base.AddOptionMapping(DbccCommand.CheckTable, "CHECKTABLE");
			base.AddOptionMapping(DbccCommand.CleanTable, "CLEANTABLE");
			base.AddOptionMapping(DbccCommand.ClearSpaceCaches, "CLEARSPACECACHES");
			base.AddOptionMapping(DbccCommand.CollectStats, "COLLECTSTATS");
			base.AddOptionMapping(DbccCommand.ConcurrencyViolation, "CONCURRENCYVIOLATION");
			base.AddOptionMapping(DbccCommand.CursorStats, "CURSORSTATS");
			base.AddOptionMapping(DbccCommand.DBRecover, "DBRECOVER");
			base.AddOptionMapping(DbccCommand.DBReindex, "DBREINDEX");
			base.AddOptionMapping(DbccCommand.DBReindexAll, "DBREINDEXALL");
			base.AddOptionMapping(DbccCommand.DBRepair, "DBREPAIR");
			base.AddOptionMapping(DbccCommand.DebugBreak, "DEBUGBREAK");
			base.AddOptionMapping(DbccCommand.DeleteInstance, "DELETEINSTANCE");
			base.AddOptionMapping(DbccCommand.DetachDB, "DETACHDB");
			base.AddOptionMapping(DbccCommand.DropCleanBuffers, "DROPCLEANBUFFERS");
			base.AddOptionMapping(DbccCommand.DropExtendedProc, "DROPEXTENDEDPROC");
			base.AddOptionMapping(DbccCommand.DumpConfig, "CONFIG");
			base.AddOptionMapping(DbccCommand.DumpDBInfo, "DBINFO");
			base.AddOptionMapping(DbccCommand.DumpDBTable, "DBTABLE");
			base.AddOptionMapping(DbccCommand.DumpLock, "LOCK");
			base.AddOptionMapping(DbccCommand.DumpLog, "LOG");
			base.AddOptionMapping(DbccCommand.DumpPage, "PAGE");
			base.AddOptionMapping(DbccCommand.DumpResource, "RESOURCE");
			base.AddOptionMapping(DbccCommand.DumpTrigger, "DUMPTRIGGER");
			base.AddOptionMapping(DbccCommand.ErrorLog, "ERRORLOG");
			base.AddOptionMapping(DbccCommand.ExtentInfo, "EXTENTINFO");
			base.AddOptionMapping(DbccCommand.FileHeader, "FILEHEADER");
			base.AddOptionMapping(DbccCommand.FixAllocation, "FIXALLOCATION");
			base.AddOptionMapping(DbccCommand.Flush, "FLUSH");
			base.AddOptionMapping(DbccCommand.FlushProcInDB, "FLUSHPROCINDB");
			base.AddOptionMapping(DbccCommand.ForceGhostCleanup, "FORCEGHOSTCLEANUP");
			base.AddOptionMapping(DbccCommand.FreeProcCache, "FREEPROCCACHE");
			base.AddOptionMapping(DbccCommand.FreeSessionCache, "FREESESSIONCACHE");
			base.AddOptionMapping(DbccCommand.FreeSystemCache, "FREESYSTEMCACHE");
			base.AddOptionMapping(DbccCommand.FreezeIO, "FREEZE_IO");
			base.AddOptionMapping(DbccCommand.Help, "HELP");
			base.AddOptionMapping(DbccCommand.IcecapQuery, "ICECAPQUERY");
			base.AddOptionMapping(DbccCommand.IncrementInstance, "INCREMENTINSTANCE");
			base.AddOptionMapping(DbccCommand.Ind, "IND");
			base.AddOptionMapping(DbccCommand.IndexDefrag, "INDEXDEFRAG");
			base.AddOptionMapping(DbccCommand.InputBuffer, "INPUTBUFFER");
			base.AddOptionMapping(DbccCommand.InvalidateTextptr, "INVALIDATE_TEXTPTR");
			base.AddOptionMapping(DbccCommand.InvalidateTextptrObjid, "INVALIDATE_TEXTPTR_OBJID");
			base.AddOptionMapping(DbccCommand.Latch, "LATCH");
			base.AddOptionMapping(DbccCommand.LogInfo, "LOGINFO");
			base.AddOptionMapping(DbccCommand.MapAllocUnit, "MAPALLOCUNIT");
			base.AddOptionMapping(DbccCommand.MemObjList, "MEMOBJLIST");
			base.AddOptionMapping(DbccCommand.MemoryMap, "MEMORYMAP");
			base.AddOptionMapping(DbccCommand.MemoryStatus, "MEMORYSTATUS");
			base.AddOptionMapping(DbccCommand.Metadata, "METADATA");
			base.AddOptionMapping(DbccCommand.MovePage, "MOVEPAGE");
			base.AddOptionMapping(DbccCommand.NoTextptr, "NO_TEXTPTR");
			base.AddOptionMapping(DbccCommand.OpenTran, "OPENTRAN");
			base.AddOptionMapping(DbccCommand.OptimizerWhatIf, "OPTIMIZER_WHATIF");
			base.AddOptionMapping(DbccCommand.OutputBuffer, "OUTPUTBUFFER");
			base.AddOptionMapping(DbccCommand.PerfMonStats, "PERFMON");
			base.AddOptionMapping(DbccCommand.PersistStackHash, "PERSISTSTACKHASH");
			base.AddOptionMapping(DbccCommand.PinTable, "PINTABLE");
			base.AddOptionMapping(DbccCommand.ProcCache, "PROCCACHE");
			base.AddOptionMapping(DbccCommand.PrtiPage, "PRTIPAGE");
			base.AddOptionMapping(DbccCommand.ReadPage, "READPAGE");
			base.AddOptionMapping(DbccCommand.RenameColumn, "RENAMECOLUMN");
			base.AddOptionMapping(DbccCommand.RuleOff, "RULEOFF");
			base.AddOptionMapping(DbccCommand.RuleOn, "RULEON");
			base.AddOptionMapping(DbccCommand.SeMetadata, "SEMETADATA");
			base.AddOptionMapping(DbccCommand.SetCpuWeight, "SETCPUWEIGHT");
			base.AddOptionMapping(DbccCommand.SetInstance, "SETINSTANCE");
			base.AddOptionMapping(DbccCommand.SetIOWeight, "SETIOWEIGHT");
			base.AddOptionMapping(DbccCommand.ShowStatistics, "SHOW_STATISTICS");
			base.AddOptionMapping(DbccCommand.ShowContig, "SHOWCONTIG");
			base.AddOptionMapping(DbccCommand.ShowDBAffinity, "SHOWDBAFFINITY");
			base.AddOptionMapping(DbccCommand.ShowFileStats, "SHOWFILESTATS");
			base.AddOptionMapping(DbccCommand.ShowOffRules, "SHOWOFFRULES");
			base.AddOptionMapping(DbccCommand.ShowOnRules, "SHOWONRULES");
			base.AddOptionMapping(DbccCommand.ShowTableAffinity, "SHOWTABLEAFFINITY");
			base.AddOptionMapping(DbccCommand.ShowText, "SHOWTEXT");
			base.AddOptionMapping(DbccCommand.ShowWeights, "SHOWWEIGHTS");
			base.AddOptionMapping(DbccCommand.ShrinkDatabase, "SHRINKDATABASE");
			base.AddOptionMapping(DbccCommand.ShrinkFile, "SHRINKFILE");
			base.AddOptionMapping(DbccCommand.SqlMgrStats, "SQLMGRSTATS");
			base.AddOptionMapping(DbccCommand.SqlPerf, "SQLPERF");
			base.AddOptionMapping(DbccCommand.StackDump, "STACKDUMP");
			base.AddOptionMapping(DbccCommand.Tec, "TEC");
			base.AddOptionMapping(DbccCommand.ThawIO, "THAW_IO");
			base.AddOptionMapping(DbccCommand.TraceOff, "TRACEOFF");
			base.AddOptionMapping(DbccCommand.TraceOn, "TRACEON");
			base.AddOptionMapping(DbccCommand.TraceStatus, "TRACESTATUS");
			base.AddOptionMapping(DbccCommand.UnpinTable, "UNPINTABLE");
			base.AddOptionMapping(DbccCommand.UpdateUsage, "UPDATEUSAGE");
			base.AddOptionMapping(DbccCommand.UsePlan, "USEPLAN");
			base.AddOptionMapping(DbccCommand.UserOptions, "USEROPTIONS");
			base.AddOptionMapping(DbccCommand.WritePage, "WRITEPAGE");
		}

		// Token: 0x040008EE RID: 2286
		internal static readonly DbccCommandsHelper Instance = new DbccCommandsHelper();
	}
}
