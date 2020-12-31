using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000D9 RID: 217
	[Serializable]
	public class IdentifierOrValueExpression : TSqlFragment
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000850C File Offset: 0x0000670C
		public string Value
		{
			get
			{
				if (this.Identifier != null)
				{
					return this.Identifier.Value;
				}
				if (this.ValueExpression == null)
				{
					return null;
				}
				Literal literal = this.ValueExpression as Literal;
				if (literal != null)
				{
					return literal.Value;
				}
				VariableReference variableReference = this.ValueExpression as VariableReference;
				if (variableReference != null)
				{
					return variableReference.Name;
				}
				GlobalVariableExpression globalVariableExpression = this.ValueExpression as GlobalVariableExpression;
				if (globalVariableExpression != null)
				{
					return globalVariableExpression.Name;
				}
				return null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000857A File Offset: 0x0000677A
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00008582 File Offset: 0x00006782
		public Identifier Identifier
		{
			get
			{
				return this._identifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._identifier = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00008592 File Offset: 0x00006792
		// (set) Token: 0x0600026A RID: 618 RVA: 0x0000859A File Offset: 0x0000679A
		public ValueExpression ValueExpression
		{
			get
			{
				return this._valueExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._valueExpression = value;
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000085AA File Offset: 0x000067AA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000085B6 File Offset: 0x000067B6
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Identifier != null)
			{
				this.Identifier.Accept(visitor);
			}
			if (this.ValueExpression != null)
			{
				this.ValueExpression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04000B6A RID: 2922
		private Identifier _identifier;

		// Token: 0x04000B6B RID: 2923
		private ValueExpression _valueExpression;
	}
}
