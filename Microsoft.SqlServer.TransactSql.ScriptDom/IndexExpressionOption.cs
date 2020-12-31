using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002D9 RID: 729
	[Serializable]
	public class IndexExpressionOption : IndexOption
	{
		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x001CE980 File Offset: 0x001CCB80
		// (set) Token: 0x06002FB8 RID: 12216 RVA: 0x001CE988 File Offset: 0x001CCB88
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

		// Token: 0x06002FB9 RID: 12217 RVA: 0x001CE998 File Offset: 0x001CCB98
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x001CE9A4 File Offset: 0x001CCBA4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
		}

		// Token: 0x04001F1A RID: 7962
		private ScalarExpression _expression;
	}
}
