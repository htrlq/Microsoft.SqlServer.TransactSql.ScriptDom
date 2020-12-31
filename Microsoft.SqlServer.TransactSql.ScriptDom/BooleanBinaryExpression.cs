using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003E7 RID: 999
	[Serializable]
	public class BooleanBinaryExpression : BooleanExpression
	{
		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x0600364B RID: 13899 RVA: 0x001D53E7 File Offset: 0x001D35E7
		// (set) Token: 0x0600364C RID: 13900 RVA: 0x001D53EF File Offset: 0x001D35EF
		public BooleanBinaryExpressionType BinaryExpressionType
		{
			get
			{
				return this._binaryExpressionType;
			}
			set
			{
				this._binaryExpressionType = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600364D RID: 13901 RVA: 0x001D53F8 File Offset: 0x001D35F8
		// (set) Token: 0x0600364E RID: 13902 RVA: 0x001D5400 File Offset: 0x001D3600
		public BooleanExpression FirstExpression
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

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600364F RID: 13903 RVA: 0x001D5410 File Offset: 0x001D3610
		// (set) Token: 0x06003650 RID: 13904 RVA: 0x001D5418 File Offset: 0x001D3618
		public BooleanExpression SecondExpression
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

		// Token: 0x06003651 RID: 13905 RVA: 0x001D5428 File Offset: 0x001D3628
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x001D5434 File Offset: 0x001D3634
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

		// Token: 0x04002102 RID: 8450
		private BooleanBinaryExpressionType _binaryExpressionType;

		// Token: 0x04002103 RID: 8451
		private BooleanExpression _firstExpression;

		// Token: 0x04002104 RID: 8452
		private BooleanExpression _secondExpression;
	}
}
