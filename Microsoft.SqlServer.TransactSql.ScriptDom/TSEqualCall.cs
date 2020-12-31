using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000284 RID: 644
	[Serializable]
	public class TSEqualCall : BooleanExpression
	{
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06002DBC RID: 11708 RVA: 0x001CC6FF File Offset: 0x001CA8FF
		// (set) Token: 0x06002DBD RID: 11709 RVA: 0x001CC707 File Offset: 0x001CA907
		public ScalarExpression FirstExpression
		{
			get
			{
				return this._firstExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._firstExpression = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06002DBE RID: 11710 RVA: 0x001CC717 File Offset: 0x001CA917
		// (set) Token: 0x06002DBF RID: 11711 RVA: 0x001CC71F File Offset: 0x001CA91F
		public ScalarExpression SecondExpression
		{
			get
			{
				return this._secondExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._secondExpression = value;
			}
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x001CC72F File Offset: 0x001CA92F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x001CC73B File Offset: 0x001CA93B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.FirstExpression != null)
			{
				this.FirstExpression.Accept(visitor);
			}
			if (this.SecondExpression != null)
			{
				this.SecondExpression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E89 RID: 7817
		private ScalarExpression _firstExpression;

		// Token: 0x04001E8A RID: 7818
		private ScalarExpression _secondExpression;
	}
}
