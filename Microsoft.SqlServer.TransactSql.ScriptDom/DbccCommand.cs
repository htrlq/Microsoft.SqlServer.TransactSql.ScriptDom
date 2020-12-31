using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000093 RID: 147
	public enum DbccCommand
	{
		// Token: 0x04000880 RID: 2176
		None,
		// Token: 0x04000881 RID: 2177
		ActiveCursors,
		// Token: 0x04000882 RID: 2178
		AddExtendedProc,
		// Token: 0x04000883 RID: 2179
		AddInstance,
		// Token: 0x04000884 RID: 2180
		AuditEvent,
		// Token: 0x04000885 RID: 2181
		AutoPilot,
		// Token: 0x04000886 RID: 2182
		Buffer,
		// Token: 0x04000887 RID: 2183
		Bytes,
		// Token: 0x04000888 RID: 2184
		CacheProfile,
		// Token: 0x04000889 RID: 2185
		CacheStats,
		// Token: 0x0400088A RID: 2186
		CallFullText,
		// Token: 0x0400088B RID: 2187
		CheckAlloc,
		// Token: 0x0400088C RID: 2188
		CheckCatalog,
		// Token: 0x0400088D RID: 2189
		CheckConstraints,
		// Token: 0x0400088E RID: 2190
		CheckDB,
		// Token: 0x0400088F RID: 2191
		CheckFileGroup,
		// Token: 0x04000890 RID: 2192
		CheckIdent,
		// Token: 0x04000891 RID: 2193
		CheckPrimaryFile,
		// Token: 0x04000892 RID: 2194
		CheckTable,
		// Token: 0x04000893 RID: 2195
		CleanTable,
		// Token: 0x04000894 RID: 2196
		ClearSpaceCaches,
		// Token: 0x04000895 RID: 2197
		CollectStats,
		// Token: 0x04000896 RID: 2198
		ConcurrencyViolation,
		// Token: 0x04000897 RID: 2199
		CursorStats,
		// Token: 0x04000898 RID: 2200
		DBRecover,
		// Token: 0x04000899 RID: 2201
		DBReindex,
		// Token: 0x0400089A RID: 2202
		DBReindexAll,
		// Token: 0x0400089B RID: 2203
		DBRepair,
		// Token: 0x0400089C RID: 2204
		DebugBreak,
		// Token: 0x0400089D RID: 2205
		DeleteInstance,
		// Token: 0x0400089E RID: 2206
		DetachDB,
		// Token: 0x0400089F RID: 2207
		DropCleanBuffers,
		// Token: 0x040008A0 RID: 2208
		DropExtendedProc,
		// Token: 0x040008A1 RID: 2209
		DumpConfig,
		// Token: 0x040008A2 RID: 2210
		DumpDBInfo,
		// Token: 0x040008A3 RID: 2211
		DumpDBTable,
		// Token: 0x040008A4 RID: 2212
		DumpLock,
		// Token: 0x040008A5 RID: 2213
		DumpLog,
		// Token: 0x040008A6 RID: 2214
		DumpPage,
		// Token: 0x040008A7 RID: 2215
		DumpResource,
		// Token: 0x040008A8 RID: 2216
		DumpTrigger,
		// Token: 0x040008A9 RID: 2217
		ErrorLog,
		// Token: 0x040008AA RID: 2218
		ExtentInfo,
		// Token: 0x040008AB RID: 2219
		FileHeader,
		// Token: 0x040008AC RID: 2220
		FixAllocation,
		// Token: 0x040008AD RID: 2221
		Flush,
		// Token: 0x040008AE RID: 2222
		FlushProcInDB,
		// Token: 0x040008AF RID: 2223
		ForceGhostCleanup,
		// Token: 0x040008B0 RID: 2224
		Free,
		// Token: 0x040008B1 RID: 2225
		FreeProcCache,
		// Token: 0x040008B2 RID: 2226
		FreeSessionCache,
		// Token: 0x040008B3 RID: 2227
		FreeSystemCache,
		// Token: 0x040008B4 RID: 2228
		FreezeIO,
		// Token: 0x040008B5 RID: 2229
		Help,
		// Token: 0x040008B6 RID: 2230
		IcecapQuery,
		// Token: 0x040008B7 RID: 2231
		IncrementInstance,
		// Token: 0x040008B8 RID: 2232
		Ind,
		// Token: 0x040008B9 RID: 2233
		IndexDefrag,
		// Token: 0x040008BA RID: 2234
		InputBuffer,
		// Token: 0x040008BB RID: 2235
		InvalidateTextptr,
		// Token: 0x040008BC RID: 2236
		InvalidateTextptrObjid,
		// Token: 0x040008BD RID: 2237
		Latch,
		// Token: 0x040008BE RID: 2238
		LogInfo,
		// Token: 0x040008BF RID: 2239
		MapAllocUnit,
		// Token: 0x040008C0 RID: 2240
		MemObjList,
		// Token: 0x040008C1 RID: 2241
		MemoryMap,
		// Token: 0x040008C2 RID: 2242
		MemoryStatus,
		// Token: 0x040008C3 RID: 2243
		Metadata,
		// Token: 0x040008C4 RID: 2244
		MovePage,
		// Token: 0x040008C5 RID: 2245
		NoTextptr,
		// Token: 0x040008C6 RID: 2246
		OpenTran,
		// Token: 0x040008C7 RID: 2247
		OptimizerWhatIf,
		// Token: 0x040008C8 RID: 2248
		OutputBuffer,
		// Token: 0x040008C9 RID: 2249
		PerfMonStats,
		// Token: 0x040008CA RID: 2250
		PersistStackHash,
		// Token: 0x040008CB RID: 2251
		PinTable,
		// Token: 0x040008CC RID: 2252
		ProcCache,
		// Token: 0x040008CD RID: 2253
		PrtiPage,
		// Token: 0x040008CE RID: 2254
		ReadPage,
		// Token: 0x040008CF RID: 2255
		RenameColumn,
		// Token: 0x040008D0 RID: 2256
		RuleOff,
		// Token: 0x040008D1 RID: 2257
		RuleOn,
		// Token: 0x040008D2 RID: 2258
		SeMetadata,
		// Token: 0x040008D3 RID: 2259
		SetCpuWeight,
		// Token: 0x040008D4 RID: 2260
		SetInstance,
		// Token: 0x040008D5 RID: 2261
		SetIOWeight,
		// Token: 0x040008D6 RID: 2262
		ShowStatistics,
		// Token: 0x040008D7 RID: 2263
		ShowContig,
		// Token: 0x040008D8 RID: 2264
		ShowDBAffinity,
		// Token: 0x040008D9 RID: 2265
		ShowFileStats,
		// Token: 0x040008DA RID: 2266
		ShowOffRules,
		// Token: 0x040008DB RID: 2267
		ShowOnRules,
		// Token: 0x040008DC RID: 2268
		ShowTableAffinity,
		// Token: 0x040008DD RID: 2269
		ShowText,
		// Token: 0x040008DE RID: 2270
		ShowWeights,
		// Token: 0x040008DF RID: 2271
		ShrinkDatabase,
		// Token: 0x040008E0 RID: 2272
		ShrinkFile,
		// Token: 0x040008E1 RID: 2273
		SqlMgrStats,
		// Token: 0x040008E2 RID: 2274
		SqlPerf,
		// Token: 0x040008E3 RID: 2275
		StackDump,
		// Token: 0x040008E4 RID: 2276
		Tec,
		// Token: 0x040008E5 RID: 2277
		ThawIO,
		// Token: 0x040008E6 RID: 2278
		TraceOff,
		// Token: 0x040008E7 RID: 2279
		TraceOn,
		// Token: 0x040008E8 RID: 2280
		TraceStatus,
		// Token: 0x040008E9 RID: 2281
		UnpinTable,
		// Token: 0x040008EA RID: 2282
		UpdateUsage,
		// Token: 0x040008EB RID: 2283
		UsePlan,
		// Token: 0x040008EC RID: 2284
		UserOptions,
		// Token: 0x040008ED RID: 2285
		WritePage
	}
}
