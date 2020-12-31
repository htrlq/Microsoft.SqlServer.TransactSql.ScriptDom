using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004E5 RID: 1253
	[Serializable]
	public class WindowDelimiter : TSqlFragment
	{
		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x001DACF8 File Offset: 0x001D8EF8
		// (set) Token: 0x06003BF2 RID: 15346 RVA: 0x001DAD00 File Offset: 0x001D8F00
		public WindowDelimiterType WindowDelimiterType
		{
			get
			{
				return this._windowDelimiterType;
			}
			set
			{
				this._windowDelimiterType = value;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06003BF3 RID: 15347 RVA: 0x001DAD09 File Offset: 0x001D8F09
		// (set) Token: 0x06003BF4 RID: 15348 RVA: 0x001DAD11 File Offset: 0x001D8F11
		public ScalarExpression OffsetValue
		{
			get
			{
				return this._offsetValue;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._offsetValue = value;
			}
		}

		// Token: 0x06003BF5 RID: 15349 RVA: 0x001DAD21 File Offset: 0x001D8F21
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003BF6 RID: 15350 RVA: 0x001DAD2D File Offset: 0x001D8F2D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.OffsetValue != null)
			{
				this.OffsetValue.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002285 RID: 8837
		private WindowDelimiterType _windowDelimiterType;

		// Token: 0x04002286 RID: 8838
		private ScalarExpression _offsetValue;
	}
}
