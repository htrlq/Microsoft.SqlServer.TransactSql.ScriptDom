using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000282 RID: 642
	[Serializable]
	public class PrintStatement : TSqlStatement
	{
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06002DB2 RID: 11698 RVA: 0x001CC66D File Offset: 0x001CA86D
		// (set) Token: 0x06002DB3 RID: 11699 RVA: 0x001CC675 File Offset: 0x001CA875
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

		// Token: 0x06002DB4 RID: 11700 RVA: 0x001CC685 File Offset: 0x001CA885
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x001CC691 File Offset: 0x001CA891
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E87 RID: 7815
		private ScalarExpression _expression;
	}
}
