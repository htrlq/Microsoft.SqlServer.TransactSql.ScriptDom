using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000408 RID: 1032
	[Serializable]
	public class UnaryExpression : ScalarExpression
	{
		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600371A RID: 14106 RVA: 0x001D6278 File Offset: 0x001D4478
		// (set) Token: 0x0600371B RID: 14107 RVA: 0x001D6280 File Offset: 0x001D4480
		public UnaryExpressionType UnaryExpressionType
		{
			get
			{
				return this._unaryExpressionType;
			}
			set
			{
				this._unaryExpressionType = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600371C RID: 14108 RVA: 0x001D6289 File Offset: 0x001D4489
		// (set) Token: 0x0600371D RID: 14109 RVA: 0x001D6291 File Offset: 0x001D4491
		public ScalarExpression Expression
		{
			get
			{
				return this._expression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._expression = value;
			}
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x001D62A1 File Offset: 0x001D44A1
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x001D62AD File Offset: 0x001D44AD
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002140 RID: 8512
		private UnaryExpressionType _unaryExpressionType;

		// Token: 0x04002141 RID: 8513
		private ScalarExpression _expression;
	}
}
