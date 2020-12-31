using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003E6 RID: 998
	[Serializable]
	public class BooleanComparisonExpression : BooleanExpression
	{
		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06003642 RID: 13890 RVA: 0x001D5361 File Offset: 0x001D3561
		// (set) Token: 0x06003643 RID: 13891 RVA: 0x001D5369 File Offset: 0x001D3569
		public BooleanComparisonType ComparisonType
		{
			get
			{
				return this._comparisonType;
			}
			set
			{
				this._comparisonType = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06003644 RID: 13892 RVA: 0x001D5372 File Offset: 0x001D3572
		// (set) Token: 0x06003645 RID: 13893 RVA: 0x001D537A File Offset: 0x001D357A
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

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06003646 RID: 13894 RVA: 0x001D538A File Offset: 0x001D358A
		// (set) Token: 0x06003647 RID: 13895 RVA: 0x001D5392 File Offset: 0x001D3592
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

		// Token: 0x06003648 RID: 13896 RVA: 0x001D53A2 File Offset: 0x001D35A2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x001D53AE File Offset: 0x001D35AE
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

		// Token: 0x040020FF RID: 8447
		private BooleanComparisonType _comparisonType;

		// Token: 0x04002100 RID: 8448
		private ScalarExpression _firstExpression;

		// Token: 0x04002101 RID: 8449
		private ScalarExpression _secondExpression;
	}
}
