using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001EB RID: 491
	[Serializable]
	public class CommonTableExpression : TSqlFragment
	{
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06002A0D RID: 10765 RVA: 0x001C831C File Offset: 0x001C651C
		// (set) Token: 0x06002A0E RID: 10766 RVA: 0x001C8324 File Offset: 0x001C6524
		public Identifier ExpressionName
		{
			get
			{
				return this._expressionName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._expressionName = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x001C8334 File Offset: 0x001C6534
		public IList<Identifier> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06002A10 RID: 10768 RVA: 0x001C833C File Offset: 0x001C653C
		// (set) Token: 0x06002A11 RID: 10769 RVA: 0x001C8344 File Offset: 0x001C6544
		public QueryExpression QueryExpression
		{
			get
			{
				return this._queryExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._queryExpression = value;
			}
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x001C8354 File Offset: 0x001C6554
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x001C8360 File Offset: 0x001C6560
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ExpressionName != null)
			{
				this.ExpressionName.Accept(visitor);
			}
			int i = 0;
			int count = this.Columns.Count;
			while (i < count)
			{
				this.Columns[i].Accept(visitor);
				i++;
			}
			if (this.QueryExpression != null)
			{
				this.QueryExpression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D73 RID: 7539
		private Identifier _expressionName;

		// Token: 0x04001D74 RID: 7540
		private List<Identifier> _columns = new List<Identifier>();

		// Token: 0x04001D75 RID: 7541
		private QueryExpression _queryExpression;
	}
}
