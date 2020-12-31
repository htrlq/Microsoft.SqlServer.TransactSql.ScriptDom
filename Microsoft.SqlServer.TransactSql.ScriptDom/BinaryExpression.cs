using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003DB RID: 987
	[Serializable]
	public class BinaryExpression : ScalarExpression
	{
		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060035F2 RID: 13810 RVA: 0x001D4D7A File Offset: 0x001D2F7A
		// (set) Token: 0x060035F3 RID: 13811 RVA: 0x001D4D82 File Offset: 0x001D2F82
		public BinaryExpressionType BinaryExpressionType
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

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060035F4 RID: 13812 RVA: 0x001D4D8B File Offset: 0x001D2F8B
		// (set) Token: 0x060035F5 RID: 13813 RVA: 0x001D4D93 File Offset: 0x001D2F93
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

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060035F6 RID: 13814 RVA: 0x001D4DA3 File Offset: 0x001D2FA3
		// (set) Token: 0x060035F7 RID: 13815 RVA: 0x001D4DAB File Offset: 0x001D2FAB
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

		// Token: 0x060035F8 RID: 13816 RVA: 0x001D4DBB File Offset: 0x001D2FBB
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x001D4DC7 File Offset: 0x001D2FC7
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

		// Token: 0x040020E4 RID: 8420
		private BinaryExpressionType _binaryExpressionType;

		// Token: 0x040020E5 RID: 8421
		private ScalarExpression _firstExpression;

		// Token: 0x040020E6 RID: 8422
		private ScalarExpression _secondExpression;
	}
}
