using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200028C RID: 652
	[Serializable]
	public class ParenthesisExpression : PrimaryExpression
	{
		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06002DE7 RID: 11751 RVA: 0x001CC942 File Offset: 0x001CAB42
		// (set) Token: 0x06002DE8 RID: 11752 RVA: 0x001CC94A File Offset: 0x001CAB4A
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

		// Token: 0x06002DE9 RID: 11753 RVA: 0x001CC95A File Offset: 0x001CAB5A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x001CC966 File Offset: 0x001CAB66
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
		}

		// Token: 0x04001E93 RID: 7827
		private ScalarExpression _expression;
	}
}
