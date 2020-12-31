using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003E8 RID: 1000
	[Serializable]
	public class BooleanIsNullExpression : BooleanExpression
	{
		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06003654 RID: 13908 RVA: 0x001D546D File Offset: 0x001D366D
		// (set) Token: 0x06003655 RID: 13909 RVA: 0x001D5475 File Offset: 0x001D3675
		public bool IsNot
		{
			get
			{
				return this._isNot;
			}
			set
			{
				this._isNot = value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06003656 RID: 13910 RVA: 0x001D547E File Offset: 0x001D367E
		// (set) Token: 0x06003657 RID: 13911 RVA: 0x001D5486 File Offset: 0x001D3686
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

		// Token: 0x06003658 RID: 13912 RVA: 0x001D5496 File Offset: 0x001D3696
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x001D54A2 File Offset: 0x001D36A2
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002105 RID: 8453
		private bool _isNot;

		// Token: 0x04002106 RID: 8454
		private ScalarExpression _expression;
	}
}
