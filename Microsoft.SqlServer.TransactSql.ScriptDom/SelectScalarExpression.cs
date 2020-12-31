using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003FF RID: 1023
	[Serializable]
	public class SelectScalarExpression : SelectElement
	{
		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060036D7 RID: 14039 RVA: 0x001D5E0A File Offset: 0x001D400A
		// (set) Token: 0x060036D8 RID: 14040 RVA: 0x001D5E12 File Offset: 0x001D4012
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

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060036D9 RID: 14041 RVA: 0x001D5E22 File Offset: 0x001D4022
		// (set) Token: 0x060036DA RID: 14042 RVA: 0x001D5E2A File Offset: 0x001D402A
		public IdentifierOrValueExpression ColumnName
		{
			get
			{
				return this._columnName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._columnName = value;
			}
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x001D5E3A File Offset: 0x001D403A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x001D5E46 File Offset: 0x001D4046
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			if (this.ColumnName != null)
			{
				this.ColumnName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400212B RID: 8491
		private ScalarExpression _expression;

		// Token: 0x0400212C RID: 8492
		private IdentifierOrValueExpression _columnName;
	}
}
