using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003DE RID: 990
	[Serializable]
	public class ComputeFunction : TSqlFragment
	{
		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06003606 RID: 13830 RVA: 0x001D4F36 File Offset: 0x001D3136
		// (set) Token: 0x06003607 RID: 13831 RVA: 0x001D4F3E File Offset: 0x001D313E
		public ComputeFunctionType ComputeFunctionType
		{
			get
			{
				return this._computeFunctionType;
			}
			set
			{
				this._computeFunctionType = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06003608 RID: 13832 RVA: 0x001D4F47 File Offset: 0x001D3147
		// (set) Token: 0x06003609 RID: 13833 RVA: 0x001D4F4F File Offset: 0x001D314F
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

		// Token: 0x0600360A RID: 13834 RVA: 0x001D4F5F File Offset: 0x001D315F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x001D4F6B File Offset: 0x001D316B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020EB RID: 8427
		private ComputeFunctionType _computeFunctionType;

		// Token: 0x040020EC RID: 8428
		private ScalarExpression _expression;
	}
}
