using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000308 RID: 776
	[Serializable]
	public class ReturnStatement : TSqlStatement
	{
		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060030B6 RID: 12470 RVA: 0x001CF976 File Offset: 0x001CDB76
		// (set) Token: 0x060030B7 RID: 12471 RVA: 0x001CF97E File Offset: 0x001CDB7E
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

		// Token: 0x060030B8 RID: 12472 RVA: 0x001CF98E File Offset: 0x001CDB8E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x001CF99A File Offset: 0x001CDB9A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F5D RID: 8029
		private ScalarExpression _expression;
	}
}
