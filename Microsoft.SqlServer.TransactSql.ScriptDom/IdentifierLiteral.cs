using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000D8 RID: 216
	[Serializable]
	public class IdentifierLiteral : Literal
	{
		// Token: 0x0600025E RID: 606 RVA: 0x000084B6 File Offset: 0x000066B6
		internal void SetUnquotedIdentifier(string text)
		{
			base.Value = text;
			this._quoteType = QuoteType.NotQuoted;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000084C6 File Offset: 0x000066C6
		internal void SetIdentifier(string text)
		{
			base.Value = Identifier.DecodeIdentifier(text, out this._quoteType);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000260 RID: 608 RVA: 0x000084DA File Offset: 0x000066DA
		public override LiteralType LiteralType
		{
			get
			{
				return LiteralType.Identifier;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000261 RID: 609 RVA: 0x000084DE File Offset: 0x000066DE
		// (set) Token: 0x06000262 RID: 610 RVA: 0x000084E6 File Offset: 0x000066E6
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

		// Token: 0x06000263 RID: 611 RVA: 0x000084EF File Offset: 0x000066EF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000084FB File Offset: 0x000066FB
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04000B69 RID: 2921
		private QuoteType _quoteType;
	}
}
