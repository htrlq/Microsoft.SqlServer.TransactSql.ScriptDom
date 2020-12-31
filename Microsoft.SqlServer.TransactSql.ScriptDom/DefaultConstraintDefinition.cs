using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200037B RID: 891
	[Serializable]
	public class DefaultConstraintDefinition : ConstraintDefinition
	{
		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x0600337F RID: 13183 RVA: 0x001D2338 File Offset: 0x001D0538
		// (set) Token: 0x06003380 RID: 13184 RVA: 0x001D2340 File Offset: 0x001D0540
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

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06003381 RID: 13185 RVA: 0x001D2350 File Offset: 0x001D0550
		// (set) Token: 0x06003382 RID: 13186 RVA: 0x001D2358 File Offset: 0x001D0558
		public bool WithValues
		{
			get
			{
				return this._withValues;
			}
			set
			{
				this._withValues = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06003383 RID: 13187 RVA: 0x001D2361 File Offset: 0x001D0561
		// (set) Token: 0x06003384 RID: 13188 RVA: 0x001D2369 File Offset: 0x001D0569
		public Identifier Column
		{
			get
			{
				return this._column;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._column = value;
			}
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x001D2379 File Offset: 0x001D0579
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x001D2385 File Offset: 0x001D0585
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			if (this.Column != null)
			{
				this.Column.Accept(visitor);
			}
		}

		// Token: 0x04002023 RID: 8227
		private ScalarExpression _expression;

		// Token: 0x04002024 RID: 8228
		private bool _withValues;

		// Token: 0x04002025 RID: 8229
		private Identifier _column;
	}
}
