using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200021A RID: 538
	[Serializable]
	public class SearchedWhenClause : WhenClause
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x001C95D5 File Offset: 0x001C77D5
		// (set) Token: 0x06002B15 RID: 11029 RVA: 0x001C95DD File Offset: 0x001C77DD
		public BooleanExpression WhenExpression
		{
			get
			{
				return this._whenExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._whenExpression = value;
			}
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x001C95ED File Offset: 0x001C77ED
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x001C95F9 File Offset: 0x001C77F9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.WhenExpression != null)
			{
				this.WhenExpression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001DBF RID: 7615
		private BooleanExpression _whenExpression;
	}
}
