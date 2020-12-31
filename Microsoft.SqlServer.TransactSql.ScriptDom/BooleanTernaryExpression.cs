using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000405 RID: 1029
	[Serializable]
	public class BooleanTernaryExpression : BooleanExpression
	{
		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060036FF RID: 14079 RVA: 0x001D60DA File Offset: 0x001D42DA
		// (set) Token: 0x06003700 RID: 14080 RVA: 0x001D60E2 File Offset: 0x001D42E2
		public BooleanTernaryExpressionType TernaryExpressionType
		{
			get
			{
				return this._ternaryExpressionType;
			}
			set
			{
				this._ternaryExpressionType = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06003701 RID: 14081 RVA: 0x001D60EB File Offset: 0x001D42EB
		// (set) Token: 0x06003702 RID: 14082 RVA: 0x001D60F3 File Offset: 0x001D42F3
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

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06003703 RID: 14083 RVA: 0x001D6103 File Offset: 0x001D4303
		// (set) Token: 0x06003704 RID: 14084 RVA: 0x001D610B File Offset: 0x001D430B
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

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06003705 RID: 14085 RVA: 0x001D611B File Offset: 0x001D431B
		// (set) Token: 0x06003706 RID: 14086 RVA: 0x001D6123 File Offset: 0x001D4323
		public ScalarExpression ThirdExpression
		{
			get
			{
				return this._thirdExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._thirdExpression = value;
			}
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x001D6133 File Offset: 0x001D4333
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x001D6140 File Offset: 0x001D4340
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
			if (this.ThirdExpression != null)
			{
				this.ThirdExpression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002137 RID: 8503
		private BooleanTernaryExpressionType _ternaryExpressionType;

		// Token: 0x04002138 RID: 8504
		private ScalarExpression _firstExpression;

		// Token: 0x04002139 RID: 8505
		private ScalarExpression _secondExpression;

		// Token: 0x0400213A RID: 8506
		private ScalarExpression _thirdExpression;
	}
}
