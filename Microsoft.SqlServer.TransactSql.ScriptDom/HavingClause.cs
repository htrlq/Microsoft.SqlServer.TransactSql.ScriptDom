using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003F4 RID: 1012
	[Serializable]
	public class HavingClause : TSqlFragment
	{
		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x0600368F RID: 13967 RVA: 0x001D58F6 File Offset: 0x001D3AF6
		// (set) Token: 0x06003690 RID: 13968 RVA: 0x001D58FE File Offset: 0x001D3AFE
		public BooleanExpression SearchCondition
		{
			get
			{
				return this._searchCondition;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._searchCondition = value;
			}
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x001D590E File Offset: 0x001D3B0E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x001D591A File Offset: 0x001D3B1A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SearchCondition != null)
			{
				this.SearchCondition.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002115 RID: 8469
		private BooleanExpression _searchCondition;
	}
}
