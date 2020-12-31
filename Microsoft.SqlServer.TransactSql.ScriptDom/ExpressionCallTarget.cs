using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000232 RID: 562
	[Serializable]
	public class ExpressionCallTarget : CallTarget
	{
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06002BD9 RID: 11225 RVA: 0x001CA52A File Offset: 0x001C872A
		// (set) Token: 0x06002BDA RID: 11226 RVA: 0x001CA532 File Offset: 0x001C8732
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

		// Token: 0x06002BDB RID: 11227 RVA: 0x001CA542 File Offset: 0x001C8742
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x001CA54E File Offset: 0x001C874E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E03 RID: 7683
		private ScalarExpression _expression;
	}
}
