using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000319 RID: 793
	[Serializable]
	public class WhereClause : TSqlFragment
	{
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x0600311F RID: 12575 RVA: 0x001CFFD1 File Offset: 0x001CE1D1
		// (set) Token: 0x06003120 RID: 12576 RVA: 0x001CFFD9 File Offset: 0x001CE1D9
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

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06003121 RID: 12577 RVA: 0x001CFFE9 File Offset: 0x001CE1E9
		// (set) Token: 0x06003122 RID: 12578 RVA: 0x001CFFF1 File Offset: 0x001CE1F1
		public CursorId Cursor
		{
			get
			{
				return this._cursor;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._cursor = value;
			}
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x001D0001 File Offset: 0x001CE201
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x001D000D File Offset: 0x001CE20D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SearchCondition != null)
			{
				this.SearchCondition.Accept(visitor);
			}
			if (this.Cursor != null)
			{
				this.Cursor.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F7A RID: 8058
		private BooleanExpression _searchCondition;

		// Token: 0x04001F7B RID: 8059
		private CursorId _cursor;
	}
}
