using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200023A RID: 570
	[Serializable]
	public class ScalarSubquery : PrimaryExpression
	{
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x001CA883 File Offset: 0x001C8A83
		// (set) Token: 0x06002C06 RID: 11270 RVA: 0x001CA88B File Offset: 0x001C8A8B
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

		// Token: 0x06002C07 RID: 11271 RVA: 0x001CA89B File Offset: 0x001C8A9B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x001CA8A7 File Offset: 0x001C8AA7
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.QueryExpression != null)
			{
				this.QueryExpression.Accept(visitor);
			}
		}

		// Token: 0x04001E0F RID: 7695
		private QueryExpression _queryExpression;
	}
}
