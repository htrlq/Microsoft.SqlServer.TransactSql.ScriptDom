using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003FB RID: 1019
	[Serializable]
	public class QueryParenthesisExpression : QueryExpression
	{
		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060036BC RID: 14012 RVA: 0x001D5BF4 File Offset: 0x001D3DF4
		// (set) Token: 0x060036BD RID: 14013 RVA: 0x001D5BFC File Offset: 0x001D3DFC
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

		// Token: 0x060036BE RID: 14014 RVA: 0x001D5C0C File Offset: 0x001D3E0C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x001D5C18 File Offset: 0x001D3E18
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.QueryExpression != null)
			{
				this.QueryExpression.Accept(visitor);
			}
		}

		// Token: 0x04002122 RID: 8482
		private QueryExpression _queryExpression;
	}
}
