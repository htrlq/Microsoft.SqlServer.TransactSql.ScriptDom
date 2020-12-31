using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000248 RID: 584
	[Serializable]
	public class ColumnWithSortOrder : TSqlFragment
	{
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x001CAD45 File Offset: 0x001C8F45
		// (set) Token: 0x06002C4E RID: 11342 RVA: 0x001CAD4D File Offset: 0x001C8F4D
		public ColumnReferenceExpression Column
		{
			get
			{
				return this._column;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._column = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x001CAD5D File Offset: 0x001C8F5D
		// (set) Token: 0x06002C50 RID: 11344 RVA: 0x001CAD65 File Offset: 0x001C8F65
		public SortOrder SortOrder
		{
			get
			{
				return this._sortOrder;
			}
			set
			{
				this._sortOrder = value;
			}
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x001CAD6E File Offset: 0x001C8F6E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x001CAD7A File Offset: 0x001C8F7A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Column != null)
			{
				this.Column.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E20 RID: 7712
		private ColumnReferenceExpression _column;

		// Token: 0x04001E21 RID: 7713
		private SortOrder _sortOrder;
	}
}
