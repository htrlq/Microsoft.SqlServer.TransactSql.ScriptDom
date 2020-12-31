using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004E6 RID: 1254
	[Serializable]
	public class WithinGroupClause : TSqlFragment
	{
		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06003BF8 RID: 15352 RVA: 0x001DAD52 File Offset: 0x001D8F52
		// (set) Token: 0x06003BF9 RID: 15353 RVA: 0x001DAD5A File Offset: 0x001D8F5A
		public OrderByClause OrderByClause
		{
			get
			{
				return this._orderByClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._orderByClause = value;
			}
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x001DAD6A File Offset: 0x001D8F6A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x001DAD76 File Offset: 0x001D8F76
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.OrderByClause != null)
			{
				this.OrderByClause.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002287 RID: 8839
		private OrderByClause _orderByClause;
	}
}
