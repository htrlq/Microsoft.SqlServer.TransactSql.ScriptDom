using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200032B RID: 811
	[Serializable]
	public class RaiseErrorLegacyStatement : TSqlStatement
	{
		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x001D046E File Offset: 0x001CE66E
		// (set) Token: 0x0600316C RID: 12652 RVA: 0x001D0476 File Offset: 0x001CE676
		public ScalarExpression FirstParameter
		{
			get
			{
				return this._firstParameter;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._firstParameter = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x001D0486 File Offset: 0x001CE686
		// (set) Token: 0x0600316E RID: 12654 RVA: 0x001D048E File Offset: 0x001CE68E
		public ValueExpression SecondParameter
		{
			get
			{
				return this._secondParameter;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._secondParameter = value;
			}
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x001D049E File Offset: 0x001CE69E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x001D04AA File Offset: 0x001CE6AA
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.FirstParameter != null)
			{
				this.FirstParameter.Accept(visitor);
			}
			if (this.SecondParameter != null)
			{
				this.SecondParameter.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F88 RID: 8072
		private ScalarExpression _firstParameter;

		// Token: 0x04001F89 RID: 8073
		private ValueExpression _secondParameter;
	}
}
