using System;
using antlr;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200016E RID: 366
	internal abstract class TSql110ParserBaseInternal : TSql100ParserBaseInternal
	{
		// Token: 0x06000A73 RID: 2675 RVA: 0x00019EA9 File Offset: 0x000180A9
		protected TSql110ParserBaseInternal(TokenBuffer tokenBuf, int k) : base(tokenBuf, k)
		{
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00019EB3 File Offset: 0x000180B3
		protected TSql110ParserBaseInternal(ParserSharedInputState state, int k) : base(state, k)
		{
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00019EBD File Offset: 0x000180BD
		protected TSql110ParserBaseInternal(TokenStream lexer, int k) : base(lexer, k)
		{
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00019EC7 File Offset: 0x000180C7
		public TSql110ParserBaseInternal(bool initialQuotedIdentifiersOn) : base(initialQuotedIdentifiersOn)
		{
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00019ED0 File Offset: 0x000180D0
		private static bool isFollowingDelimiter(WindowDelimiter delimiter)
		{
			return delimiter != null && (delimiter.WindowDelimiterType == WindowDelimiterType.ValueFollowing || delimiter.WindowDelimiterType == WindowDelimiterType.UnboundedFollowing);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00019EEB File Offset: 0x000180EB
		private static bool isPrecedingDelimiter(WindowDelimiter delimiter)
		{
			return delimiter != null && (delimiter.WindowDelimiterType == WindowDelimiterType.ValuePreceding || delimiter.WindowDelimiterType == WindowDelimiterType.UnboundedPreceding);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00019F08 File Offset: 0x00018108
		protected static void CheckWindowFrame(WindowFrameClause windowFrameClause)
		{
			bool flag = windowFrameClause.Top != null && (windowFrameClause.Top.WindowDelimiterType == WindowDelimiterType.ValuePreceding || windowFrameClause.Top.WindowDelimiterType == WindowDelimiterType.ValueFollowing);
			bool flag2 = windowFrameClause.Bottom != null && (windowFrameClause.Bottom.WindowDelimiterType == WindowDelimiterType.ValuePreceding || windowFrameClause.Bottom.WindowDelimiterType == WindowDelimiterType.ValueFollowing);
			if (windowFrameClause.WindowFrameType == WindowFrameType.Range && (flag || flag2))
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46099", windowFrameClause, TSqlParserResource.SQL46099Message, new string[0]);
			}
			if (windowFrameClause.Top == null)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46100", windowFrameClause, TSqlParserResource.SQL46100Message, new string[0]);
			}
			if (windowFrameClause.Bottom == null && TSql110ParserBaseInternal.isFollowingDelimiter(windowFrameClause.Top))
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46100", windowFrameClause, TSqlParserResource.SQL46100Message, new string[0]);
			}
			if (TSql110ParserBaseInternal.isFollowingDelimiter(windowFrameClause.Top) && TSql110ParserBaseInternal.isPrecedingDelimiter(windowFrameClause.Bottom))
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46100", windowFrameClause, TSqlParserResource.SQL46100Message, new string[0]);
			}
			if (windowFrameClause.Top.WindowDelimiterType == WindowDelimiterType.UnboundedFollowing || (windowFrameClause.Bottom != null && windowFrameClause.Bottom.WindowDelimiterType == WindowDelimiterType.UnboundedPreceding))
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46100", windowFrameClause, TSqlParserResource.SQL46100Message, new string[0]);
			}
			if (TSql110ParserBaseInternal.isFollowingDelimiter(windowFrameClause.Top) && windowFrameClause.Bottom != null && windowFrameClause.Bottom.WindowDelimiterType == WindowDelimiterType.CurrentRow)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46100", windowFrameClause, TSqlParserResource.SQL46100Message, new string[0]);
			}
			if (windowFrameClause.Top.WindowDelimiterType == WindowDelimiterType.CurrentRow && TSql110ParserBaseInternal.isPrecedingDelimiter(windowFrameClause.Bottom))
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46100", windowFrameClause, TSqlParserResource.SQL46100Message, new string[0]);
			}
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0001A0AC File Offset: 0x000182AC
		protected string[] OptionValidForCreateDatabase()
		{
			return TSql110ParserBaseInternal._optionsValidForCreateDatabase;
		}

		// Token: 0x04000E61 RID: 3681
		private static string[] _optionsValidForCreateDatabase = new string[]
		{
			"CONTAINMENT",
			"DEFAULT_LANGUAGE",
			"DEFAULT_FULLTEXT_LANGUAGE",
			"FILESTREAM",
			"NESTED_TRIGGERS",
			"TRANSFORM_NOISE_WORDS",
			"TWO_DIGIT_YEAR_CUTOFF"
		};
	}
}
