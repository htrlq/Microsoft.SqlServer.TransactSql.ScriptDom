using System;
using System.Text;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000D1 RID: 209
	[Serializable]
	public class Identifier : TSqlFragment
	{
		// Token: 0x06000241 RID: 577 RVA: 0x00008230 File Offset: 0x00006430
		public static string DecodeIdentifier(string identifier, out QuoteType quote)
		{
			if (identifier == null || identifier.Length <= 2)
			{
				quote = QuoteType.NotQuoted;
				return identifier;
			}
			if (identifier.Length == 0 || (identifier[0] != '[' && identifier[0] != '"'))
			{
				quote = QuoteType.NotQuoted;
				return identifier;
			}
			string text = identifier.Substring(1, identifier.Length - 2);
			if (identifier[0] == '[')
			{
				quote = QuoteType.SquareBracket;
				return text.Replace("]]", "]");
			}
			quote = QuoteType.DoubleQuote;
			return text.Replace("\"\"", "\"");
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000082B4 File Offset: 0x000064B4
		public static string EncodeIdentifier(string identifier)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("[");
			stringBuilder.Append(identifier.Replace("]", "]]"));
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000082FC File Offset: 0x000064FC
		public static string EncodeIdentifier(string identifier, QuoteType quoteType)
		{
			StringBuilder stringBuilder = new StringBuilder();
			switch (quoteType)
			{
			case QuoteType.NotQuoted:
				return identifier;
			case QuoteType.SquareBracket:
				stringBuilder.Append("[");
				stringBuilder.Append(identifier.Replace("]", "]]"));
				stringBuilder.Append("]");
				break;
			case QuoteType.DoubleQuote:
				stringBuilder.Append("\"");
				stringBuilder.Append(identifier.Replace("\"", "\"\""));
				stringBuilder.Append("\"");
				break;
			default:
				throw new ArgumentOutOfRangeException("quoteType");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000839A File Offset: 0x0000659A
		internal void SetUnquotedIdentifier(string text)
		{
			this._value = text;
			this._quoteType = QuoteType.NotQuoted;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000083AA File Offset: 0x000065AA
		internal void SetIdentifier(string text)
		{
			this._value = Identifier.DecodeIdentifier(text, out this._quoteType);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000246 RID: 582 RVA: 0x000083BE File Offset: 0x000065BE
		// (set) Token: 0x06000247 RID: 583 RVA: 0x000083C6 File Offset: 0x000065C6
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000083CF File Offset: 0x000065CF
		// (set) Token: 0x06000249 RID: 585 RVA: 0x000083D7 File Offset: 0x000065D7
		public QuoteType QuoteType
		{
			get
			{
				return this._quoteType;
			}
			set
			{
				this._quoteType = value;
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000083E0 File Offset: 0x000065E0
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000083EC File Offset: 0x000065EC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04000B5D RID: 2909
		private const string EscapedRSquareParen = "]]";

		// Token: 0x04000B5E RID: 2910
		private const string EscapedQuote = "\"\"";

		// Token: 0x04000B5F RID: 2911
		private const string Quote = "\"";

		// Token: 0x04000B60 RID: 2912
		private const char LSquareParenChar = '[';

		// Token: 0x04000B61 RID: 2913
		private const char RSquareParenChar = ']';

		// Token: 0x04000B62 RID: 2914
		private const char QuoteChar = '"';

		// Token: 0x04000B63 RID: 2915
		internal const int MaxIdentifierLength = 128;

		// Token: 0x04000B64 RID: 2916
		private string _value;

		// Token: 0x04000B65 RID: 2917
		private QuoteType _quoteType;
	}
}
