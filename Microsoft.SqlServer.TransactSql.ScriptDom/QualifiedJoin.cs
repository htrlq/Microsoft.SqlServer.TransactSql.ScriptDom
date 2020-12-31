using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003F8 RID: 1016
	[Serializable]
	public class QualifiedJoin : JoinTableReference
	{
		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060036A6 RID: 13990 RVA: 0x001D5A9D File Offset: 0x001D3C9D
		// (set) Token: 0x060036A7 RID: 13991 RVA: 0x001D5AA5 File Offset: 0x001D3CA5
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

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060036A8 RID: 13992 RVA: 0x001D5AB5 File Offset: 0x001D3CB5
		// (set) Token: 0x060036A9 RID: 13993 RVA: 0x001D5ABD File Offset: 0x001D3CBD
		public QualifiedJoinType QualifiedJoinType
		{
			get
			{
				return this._qualifiedJoinType;
			}
			set
			{
				this._qualifiedJoinType = value;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060036AA RID: 13994 RVA: 0x001D5AC6 File Offset: 0x001D3CC6
		// (set) Token: 0x060036AB RID: 13995 RVA: 0x001D5ACE File Offset: 0x001D3CCE
		public JoinHint JoinHint
		{
			get
			{
				return this._joinHint;
			}
			set
			{
				this._joinHint = value;
			}
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x001D5AD7 File Offset: 0x001D3CD7
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x001D5AE3 File Offset: 0x001D3CE3
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.SearchCondition != null)
			{
				this.SearchCondition.Accept(visitor);
			}
		}

		// Token: 0x0400211B RID: 8475
		private BooleanExpression _searchCondition;

		// Token: 0x0400211C RID: 8476
		private QualifiedJoinType _qualifiedJoinType;

		// Token: 0x0400211D RID: 8477
		private JoinHint _joinHint;
	}
}
