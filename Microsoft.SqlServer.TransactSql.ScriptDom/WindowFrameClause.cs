using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004E4 RID: 1252
	[Serializable]
	public class WindowFrameClause : TSqlFragment
	{
		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06003BE8 RID: 15336 RVA: 0x001DAC72 File Offset: 0x001D8E72
		// (set) Token: 0x06003BE9 RID: 15337 RVA: 0x001DAC7A File Offset: 0x001D8E7A
		public WindowDelimiter Top
		{
			get
			{
				return this._top;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._top = value;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06003BEA RID: 15338 RVA: 0x001DAC8A File Offset: 0x001D8E8A
		// (set) Token: 0x06003BEB RID: 15339 RVA: 0x001DAC92 File Offset: 0x001D8E92
		public WindowDelimiter Bottom
		{
			get
			{
				return this._bottom;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._bottom = value;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06003BEC RID: 15340 RVA: 0x001DACA2 File Offset: 0x001D8EA2
		// (set) Token: 0x06003BED RID: 15341 RVA: 0x001DACAA File Offset: 0x001D8EAA
		public WindowFrameType WindowFrameType
		{
			get
			{
				return this._windowFrameType;
			}
			set
			{
				this._windowFrameType = value;
			}
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x001DACB3 File Offset: 0x001D8EB3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003BEF RID: 15343 RVA: 0x001DACBF File Offset: 0x001D8EBF
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Top != null)
			{
				this.Top.Accept(visitor);
			}
			if (this.Bottom != null)
			{
				this.Bottom.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002282 RID: 8834
		private WindowDelimiter _top;

		// Token: 0x04002283 RID: 8835
		private WindowDelimiter _bottom;

		// Token: 0x04002284 RID: 8836
		private WindowFrameType _windowFrameType;
	}
}
