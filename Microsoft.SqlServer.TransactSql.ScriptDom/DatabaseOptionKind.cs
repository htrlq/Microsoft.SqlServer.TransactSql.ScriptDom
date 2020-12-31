using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200008F RID: 143
	public enum DatabaseOptionKind
	{
		// Token: 0x0400083C RID: 2108
		Online,
		// Token: 0x0400083D RID: 2109
		Offline,
		// Token: 0x0400083E RID: 2110
		Emergency,
		// Token: 0x0400083F RID: 2111
		SingleUser,
		// Token: 0x04000840 RID: 2112
		RestrictedUser,
		// Token: 0x04000841 RID: 2113
		MultiUser,
		// Token: 0x04000842 RID: 2114
		ReadOnly,
		// Token: 0x04000843 RID: 2115
		ReadWrite,
		// Token: 0x04000844 RID: 2116
		EnableBroker,
		// Token: 0x04000845 RID: 2117
		DisableBroker,
		// Token: 0x04000846 RID: 2118
		NewBroker,
		// Token: 0x04000847 RID: 2119
		ErrorBrokerConversations,
		// Token: 0x04000848 RID: 2120
		DBChaining,
		// Token: 0x04000849 RID: 2121
		Trustworthy,
		// Token: 0x0400084A RID: 2122
		CursorCloseOnCommit,
		// Token: 0x0400084B RID: 2123
		AutoClose,
		// Token: 0x0400084C RID: 2124
		AutoCreateStatistics,
		// Token: 0x0400084D RID: 2125
		AutoShrink,
		// Token: 0x0400084E RID: 2126
		AutoUpdateStatistics,
		// Token: 0x0400084F RID: 2127
		AutoUpdateStatisticsAsync,
		// Token: 0x04000850 RID: 2128
		AnsiNullDefault,
		// Token: 0x04000851 RID: 2129
		AnsiNulls,
		// Token: 0x04000852 RID: 2130
		AnsiPadding,
		// Token: 0x04000853 RID: 2131
		AnsiWarnings,
		// Token: 0x04000854 RID: 2132
		ArithAbort,
		// Token: 0x04000855 RID: 2133
		ConcatNullYieldsNull,
		// Token: 0x04000856 RID: 2134
		NumericRoundAbort,
		// Token: 0x04000857 RID: 2135
		QuotedIdentifier,
		// Token: 0x04000858 RID: 2136
		RecursiveTriggers,
		// Token: 0x04000859 RID: 2137
		TornPageDetection,
		// Token: 0x0400085A RID: 2138
		DateCorrelationOptimization,
		// Token: 0x0400085B RID: 2139
		AllowSnapshotIsolation,
		// Token: 0x0400085C RID: 2140
		ReadCommittedSnapshot,
		// Token: 0x0400085D RID: 2141
		Encryption,
		// Token: 0x0400085E RID: 2142
		HonorBrokerPriority,
		// Token: 0x0400085F RID: 2143
		VarDecimalStorageFormat,
		// Token: 0x04000860 RID: 2144
		SupplementalLogging,
		// Token: 0x04000861 RID: 2145
		CompatibilityLevel,
		// Token: 0x04000862 RID: 2146
		CursorDefault,
		// Token: 0x04000863 RID: 2147
		Recovery,
		// Token: 0x04000864 RID: 2148
		PageVerify,
		// Token: 0x04000865 RID: 2149
		Partner,
		// Token: 0x04000866 RID: 2150
		Witness,
		// Token: 0x04000867 RID: 2151
		Parameterization,
		// Token: 0x04000868 RID: 2152
		ChangeTracking,
		// Token: 0x04000869 RID: 2153
		DefaultLanguage,
		// Token: 0x0400086A RID: 2154
		DefaultFullTextLanguage,
		// Token: 0x0400086B RID: 2155
		NestedTriggers,
		// Token: 0x0400086C RID: 2156
		TransformNoiseWords,
		// Token: 0x0400086D RID: 2157
		TwoDigitYearCutoff,
		// Token: 0x0400086E RID: 2158
		Containment,
		// Token: 0x0400086F RID: 2159
		Hadr,
		// Token: 0x04000870 RID: 2160
		FileStream,
		// Token: 0x04000871 RID: 2161
		Edition,
		// Token: 0x04000872 RID: 2162
		MaxSize,
		// Token: 0x04000873 RID: 2163
		TargetRecoveryTime,
		// Token: 0x04000874 RID: 2164
		MemoryOptimizedData,
		// Token: 0x04000875 RID: 2165
		DelayedDurability,
		// Token: 0x04000876 RID: 2166
		MemoryOptimizedElevateToSnapshot
	}
}
