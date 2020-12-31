using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000201 RID: 513
	[Serializable]
	public class QueryDerivedTable : TableReferenceWithAliasAndColumns
	{
		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06002A7D RID: 10877 RVA: 0x001C8B4E File Offset: 0x001C6D4E
		// (set) Token: 0x06002A7E RID: 10878 RVA: 0x001C8B56 File Offset: 0x001C6D56
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

		// Token: 0x06002A7F RID: 10879 RVA: 0x001C8B66 File Offset: 0x001C6D66
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x001C8B72 File Offset: 0x001C6D72
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.QueryExpression != null)
			{
				this.QueryExpression.Accept(visitor);
			}
		}

		// Token: 0x04001D92 RID: 7570
		private QueryExpression _queryExpression;
	}
}
