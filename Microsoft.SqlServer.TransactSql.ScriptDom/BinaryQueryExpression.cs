using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000409 RID: 1033
	[Serializable]
	public class BinaryQueryExpression : QueryExpression
	{
		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x001D62D2 File Offset: 0x001D44D2
		// (set) Token: 0x06003722 RID: 14114 RVA: 0x001D62DA File Offset: 0x001D44DA
		public BinaryQueryExpressionType BinaryQueryExpressionType
		{
			get
			{
				return this._binaryQueryExpressionType;
			}
			set
			{
				this._binaryQueryExpressionType = value;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06003723 RID: 14115 RVA: 0x001D62E3 File Offset: 0x001D44E3
		// (set) Token: 0x06003724 RID: 14116 RVA: 0x001D62EB File Offset: 0x001D44EB
		public bool All
		{
			get
			{
				return this._all;
			}
			set
			{
				this._all = value;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06003725 RID: 14117 RVA: 0x001D62F4 File Offset: 0x001D44F4
		// (set) Token: 0x06003726 RID: 14118 RVA: 0x001D62FC File Offset: 0x001D44FC
		public QueryExpression FirstQueryExpression
		{
			get
			{
				return this._firstQueryExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._firstQueryExpression = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06003727 RID: 14119 RVA: 0x001D630C File Offset: 0x001D450C
		// (set) Token: 0x06003728 RID: 14120 RVA: 0x001D6314 File Offset: 0x001D4514
		public QueryExpression SecondQueryExpression
		{
			get
			{
				return this._secondQueryExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._secondQueryExpression = value;
			}
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x001D6324 File Offset: 0x001D4524
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x001D6330 File Offset: 0x001D4530
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.FirstQueryExpression != null)
			{
				this.FirstQueryExpression.Accept(visitor);
			}
			if (this.SecondQueryExpression != null)
			{
				this.SecondQueryExpression.Accept(visitor);
			}
		}

		// Token: 0x04002142 RID: 8514
		private BinaryQueryExpressionType _binaryQueryExpressionType;

		// Token: 0x04002143 RID: 8515
		private bool _all;

		// Token: 0x04002144 RID: 8516
		private QueryExpression _firstQueryExpression;

		// Token: 0x04002145 RID: 8517
		private QueryExpression _secondQueryExpression;
	}
}
