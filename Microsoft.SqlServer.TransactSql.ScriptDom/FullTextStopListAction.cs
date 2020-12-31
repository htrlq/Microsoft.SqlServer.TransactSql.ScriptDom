using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004A2 RID: 1186
	[Serializable]
	public class FullTextStopListAction : TSqlFragment
	{
		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06003A60 RID: 14944 RVA: 0x001D932D File Offset: 0x001D752D
		// (set) Token: 0x06003A61 RID: 14945 RVA: 0x001D9335 File Offset: 0x001D7535
		public bool IsAdd
		{
			get
			{
				return this._isAdd;
			}
			set
			{
				this._isAdd = value;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06003A62 RID: 14946 RVA: 0x001D933E File Offset: 0x001D753E
		// (set) Token: 0x06003A63 RID: 14947 RVA: 0x001D9346 File Offset: 0x001D7546
		public bool IsAll
		{
			get
			{
				return this._isAll;
			}
			set
			{
				this._isAll = value;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06003A64 RID: 14948 RVA: 0x001D934F File Offset: 0x001D754F
		// (set) Token: 0x06003A65 RID: 14949 RVA: 0x001D9357 File Offset: 0x001D7557
		public Literal StopWord
		{
			get
			{
				return this._stopWord;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._stopWord = value;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06003A66 RID: 14950 RVA: 0x001D9367 File Offset: 0x001D7567
		// (set) Token: 0x06003A67 RID: 14951 RVA: 0x001D936F File Offset: 0x001D756F
		public IdentifierOrValueExpression LanguageTerm
		{
			get
			{
				return this._languageTerm;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._languageTerm = value;
			}
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x001D937F File Offset: 0x001D757F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A69 RID: 14953 RVA: 0x001D938B File Offset: 0x001D758B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.StopWord != null)
			{
				this.StopWord.Accept(visitor);
			}
			if (this.LanguageTerm != null)
			{
				this.LanguageTerm.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002212 RID: 8722
		private bool _isAdd;

		// Token: 0x04002213 RID: 8723
		private bool _isAll;

		// Token: 0x04002214 RID: 8724
		private Literal _stopWord;

		// Token: 0x04002215 RID: 8725
		private IdentifierOrValueExpression _languageTerm;
	}
}
