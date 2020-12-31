using System;
using System.Globalization;
using System.Text;

namespace Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator
{
	// Token: 0x02000199 RID: 409
	internal static class ScriptGeneratorSupporter
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x0001FC40 File Offset: 0x0001DE40
		public static int TokenTypeCount
		{
			get
			{
				return ScriptGeneratorSupporter._typeStrings.Length;
			}
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0001FC4C File Offset: 0x0001DE4C
		public static string GetCasedString(string str, KeywordCasing casing)
		{
			switch (casing)
			{
			case KeywordCasing.Lowercase:
				return str.ToLowerInvariant();
			case KeywordCasing.Uppercase:
				return str.ToUpperInvariant();
			case KeywordCasing.PascalCase:
				return ScriptGeneratorSupporter.GetPascalCase(str);
			default:
				return string.Empty;
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0001FC8C File Offset: 0x0001DE8C
		public static string GetPascalCase(string str)
		{
			str = str.ToLowerInvariant();
			char value = char.ToUpperInvariant(str[0]);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(value);
			stringBuilder.Append(str.Substring(1));
			return stringBuilder.ToString();
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0001FCD0 File Offset: 0x0001DED0
		public static string GetLowerCase(TSqlTokenType tokenType)
		{
			if (tokenType < TSqlTokenType.None || tokenType >= (TSqlTokenType)ScriptGeneratorSupporter._typeStrings.Length)
			{
				throw new ArgumentOutOfRangeException("tokenType");
			}
			string text = ScriptGeneratorSupporter._typeStrings[(int)tokenType];
			if (string.IsNullOrEmpty(text))
			{
				throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, SqlScriptGeneratorResource.TokenTypeDoesNotHaveStringRepresentation, new object[]
				{
					tokenType
				}));
			}
			return text;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0001FD2D File Offset: 0x0001DF2D
		public static string GetUpperCase(TSqlTokenType tokenType)
		{
			return ScriptGeneratorSupporter.GetLowerCase(tokenType).ToUpperInvariant();
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0001FD3A File Offset: 0x0001DF3A
		public static string GetPascalCase(TSqlTokenType tokenType)
		{
			return ScriptGeneratorSupporter.GetPascalCase(ScriptGeneratorSupporter.GetLowerCase(tokenType));
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0001FD48 File Offset: 0x0001DF48
		public static string GetTokenString(TSqlTokenType tokenType, KeywordCasing casing)
		{
			switch (casing)
			{
			case KeywordCasing.Lowercase:
				return ScriptGeneratorSupporter.GetLowerCase(tokenType);
			case KeywordCasing.Uppercase:
				return ScriptGeneratorSupporter.GetUpperCase(tokenType);
			case KeywordCasing.PascalCase:
				return ScriptGeneratorSupporter.GetPascalCase(tokenType);
			default:
				return string.Empty;
			}
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0001FD88 File Offset: 0x0001DF88
		public static TSqlParserToken CreateWhitespaceToken(int count)
		{
			string text = new string(' ', count);
			return new TSqlParserToken(TSqlTokenType.WhiteSpace, text);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0001FDA9 File Offset: 0x0001DFA9
		internal static void CheckForNullReference(object variable, string variableName)
		{
			if (variableName == null)
			{
				throw new ArgumentNullException("variableName");
			}
			if (variable == null)
			{
				throw new ArgumentNullException(variableName);
			}
		}

		// Token: 0x04000FD3 RID: 4051
		internal const string EscapedRSquareParen = "]]";

		// Token: 0x04000FD4 RID: 4052
		internal const string EscapedQuote = "\"\"";

		// Token: 0x04000FD5 RID: 4053
		internal const string Quote = "\"";

		// Token: 0x04000FD6 RID: 4054
		private static string[] _typeStrings = new string[]
		{
			"",
			"",
			"",
			"",
			"add",
			"all",
			"alter",
			"and",
			"any",
			"as",
			"asc",
			"authorization",
			"backup",
			"begin",
			"between",
			"break",
			"browse",
			"bulk",
			"by",
			"cascade",
			"case",
			"check",
			"checkpoint",
			"close",
			"clustered",
			"coalesce",
			"collate",
			"column",
			"commit",
			"compute",
			"constraint",
			"contains",
			"containstable",
			"continue",
			"convert",
			"create",
			"cross",
			"current",
			"current_date",
			"current_time",
			"current_timestamp",
			"current_user",
			"cursor",
			"database",
			"dbcc",
			"deallocate",
			"declare",
			"default",
			"delete",
			"deny",
			"desc",
			"distinct",
			"distributed",
			"double",
			"drop",
			"else",
			"end",
			"errlvl",
			"escape",
			"except",
			"exec",
			"execute",
			"exists",
			"exit",
			"fetch",
			"file",
			"fillfactor",
			"for",
			"foreign",
			"freetext",
			"freetexttable",
			"from",
			"full",
			"function",
			"goto",
			"grant",
			"group",
			"having",
			"holdlock",
			"identity",
			"identity_insert",
			"identitycol",
			"if",
			"in",
			"index",
			"inner",
			"insert",
			"intersect",
			"into",
			"is",
			"join",
			"key",
			"kill",
			"left",
			"like",
			"lineno",
			"national",
			"nocheck",
			"nonclustered",
			"not",
			"null",
			"nullif",
			"of",
			"off",
			"offsets",
			"on",
			"open",
			"opendatasource",
			"openquery",
			"openrowset",
			"openxml",
			"option",
			"or",
			"order",
			"outer",
			"over",
			"percent",
			"plan",
			"primary",
			"print",
			"proc",
			"procedure",
			"public",
			"raiserror",
			"read",
			"readtext",
			"reconfigure",
			"references",
			"replication",
			"restore",
			"restrict",
			"return",
			"revoke",
			"right",
			"rollback",
			"rowcount",
			"rowguidcol",
			"rule",
			"save",
			"schema",
			"select",
			"session_user",
			"set",
			"setuser",
			"shutdown",
			"some",
			"statistics",
			"system_user",
			"table",
			"textsize",
			"then",
			"to",
			"top",
			"tran",
			"transaction",
			"trigger",
			"truncate",
			"tsequal",
			"union",
			"unique",
			"update",
			"updatetext",
			"use",
			"user",
			"values",
			"varying",
			"view",
			"waitfor",
			"when",
			"where",
			"while",
			"with",
			"writetext",
			"disk",
			"precision",
			"external",
			"revert",
			"pivot",
			"unpivot",
			"tablesample",
			"dump",
			"load",
			"merge",
			"stoplist",
			"semantickeyphrasetable",
			"semanticsimilaritytable",
			"semanticsimilaritydetailstable",
			"try_convert",
			"!",
			"%",
			"&",
			"(",
			")",
			"{",
			"}",
			"*",
			"*=",
			"+",
			",",
			"-",
			".",
			"/",
			":",
			"::",
			";",
			"<",
			"=",
			"=*",
			">",
			"^",
			"|",
			"~",
			"+=",
			"-=",
			"/=",
			"%=",
			"&=",
			"|=",
			"^=",
			"go",
			"",
			"",
			"",
			"",
			"",
			"",
			"",
			"",
			"",
			"",
			"",
			"",
			"",
			"",
			"",
			"",
			"",
			"",
			"",
			""
		};
	}
}
