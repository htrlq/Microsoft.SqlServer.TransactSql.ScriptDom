using System;
using System.Globalization;
using antlr;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000170 RID: 368
	internal abstract class TSql120ParserBaseInternal : TSql110ParserBaseInternal
	{
		// Token: 0x06000A8C RID: 2700 RVA: 0x0001A3B9 File Offset: 0x000185B9
		protected TSql120ParserBaseInternal(TokenBuffer tokenBuf, int k) : base(tokenBuf, k)
		{
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0001A3C3 File Offset: 0x000185C3
		protected TSql120ParserBaseInternal(ParserSharedInputState state, int k) : base(state, k)
		{
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0001A3CD File Offset: 0x000185CD
		protected TSql120ParserBaseInternal(TokenStream lexer, int k) : base(lexer, k)
		{
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0001A3D7 File Offset: 0x000185D7
		public TSql120ParserBaseInternal(bool initialQuotedIdentifiersOn) : base(initialQuotedIdentifiersOn)
		{
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0001A3E0 File Offset: 0x000185E0
		protected static void CheckLowPriorityLockWaitValue(IntegerLiteral maxDuration, AbortAfterWaitType abortAfterWait)
		{
			int num;
			if (!int.TryParse(maxDuration.Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out num) || num > 71582 || num < 0)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46101", maxDuration, TSqlParserResource.SQL46101Message, new string[]
				{
					maxDuration.Value
				});
			}
			if (num == 0 && abortAfterWait == AbortAfterWaitType.Self)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46102", maxDuration, TSqlParserResource.SQL46102Message, new string[]
				{
					maxDuration.Value,
					"SELF"
				});
			}
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0001A460 File Offset: 0x00018660
		protected static void VerifyAllowedIndexOption120(IndexAffectingStatement statement, IndexOption option)
		{
			TSql80ParserBaseInternal.VerifyAllowedIndexOption(statement, option, SqlVersionFlags.TSql120);
			if (option is OnlineIndexOption)
			{
				OnlineIndexOption onlineIndexOption = option as OnlineIndexOption;
				if (onlineIndexOption.LowPriorityLockWaitOption != null)
				{
					switch (statement)
					{
					case IndexAffectingStatement.AlterTableRebuildOnePartition:
					case IndexAffectingStatement.AlterTableRebuildAllPartitions:
					case IndexAffectingStatement.AlterIndexRebuildOnePartition:
					case IndexAffectingStatement.AlterIndexRebuildAllPartitions:
						break;
					default:
						TSql80ParserBaseInternal.ThrowWrongIndexOptionError(statement, onlineIndexOption.LowPriorityLockWaitOption);
						break;
					}
				}
			}
		}
	}
}
