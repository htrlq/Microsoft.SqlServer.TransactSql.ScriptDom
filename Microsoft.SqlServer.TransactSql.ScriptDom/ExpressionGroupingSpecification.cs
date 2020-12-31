using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003EC RID: 1004
	[Serializable]
	public class ExpressionGroupingSpecification : GroupingSpecification
	{
		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x0600366C RID: 13932 RVA: 0x001D55BA File Offset: 0x001D37BA
		// (set) Token: 0x0600366D RID: 13933 RVA: 0x001D55C2 File Offset: 0x001D37C2
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

		// Token: 0x0600366E RID: 13934 RVA: 0x001D55D2 File Offset: 0x001D37D2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x001D55DE File Offset: 0x001D37DE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400210C RID: 8460
		private ScalarExpression _expression;
	}
}
