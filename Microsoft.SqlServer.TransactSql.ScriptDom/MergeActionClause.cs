using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000469 RID: 1129
	[Serializable]
	public class MergeActionClause : TSqlFragment
	{
		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x0600393F RID: 14655 RVA: 0x001D8269 File Offset: 0x001D6469
		// (set) Token: 0x06003940 RID: 14656 RVA: 0x001D8271 File Offset: 0x001D6471
		public MergeCondition Condition
		{
			get
			{
				return this._condition;
			}
			set
			{
				this._condition = value;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06003941 RID: 14657 RVA: 0x001D827A File Offset: 0x001D647A
		// (set) Token: 0x06003942 RID: 14658 RVA: 0x001D8282 File Offset: 0x001D6482
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

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06003943 RID: 14659 RVA: 0x001D8292 File Offset: 0x001D6492
		// (set) Token: 0x06003944 RID: 14660 RVA: 0x001D829A File Offset: 0x001D649A
		public MergeAction Action
		{
			get
			{
				return this._action;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._action = value;
			}
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x001D82AA File Offset: 0x001D64AA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x001D82B6 File Offset: 0x001D64B6
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SearchCondition != null)
			{
				this.SearchCondition.Accept(visitor);
			}
			if (this.Action != null)
			{
				this.Action.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021CC RID: 8652
		private MergeCondition _condition;

		// Token: 0x040021CD RID: 8653
		private BooleanExpression _searchCondition;

		// Token: 0x040021CE RID: 8654
		private MergeAction _action;
	}
}
