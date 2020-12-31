using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003E5 RID: 997
	[Serializable]
	public class BooleanParenthesisExpression : BooleanExpression
	{
		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600363D RID: 13885 RVA: 0x001D5318 File Offset: 0x001D3518
		// (set) Token: 0x0600363E RID: 13886 RVA: 0x001D5320 File Offset: 0x001D3520
		public BooleanExpression Expression
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

		// Token: 0x0600363F RID: 13887 RVA: 0x001D5330 File Offset: 0x001D3530
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x001D533C File Offset: 0x001D353C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020FE RID: 8446
		private BooleanExpression _expression;
	}
}
