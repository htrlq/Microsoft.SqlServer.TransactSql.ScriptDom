using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003F5 RID: 1013
	[Serializable]
	public class IdentityFunctionCall : ScalarExpression
	{
		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06003694 RID: 13972 RVA: 0x001D593F File Offset: 0x001D3B3F
		// (set) Token: 0x06003695 RID: 13973 RVA: 0x001D5947 File Offset: 0x001D3B47
		public DataTypeReference DataType
		{
			get
			{
				return this._dataType;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._dataType = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06003696 RID: 13974 RVA: 0x001D5957 File Offset: 0x001D3B57
		// (set) Token: 0x06003697 RID: 13975 RVA: 0x001D595F File Offset: 0x001D3B5F
		public ScalarExpression Seed
		{
			get
			{
				return this._seed;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._seed = value;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06003698 RID: 13976 RVA: 0x001D596F File Offset: 0x001D3B6F
		// (set) Token: 0x06003699 RID: 13977 RVA: 0x001D5977 File Offset: 0x001D3B77
		public ScalarExpression Increment
		{
			get
			{
				return this._increment;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._increment = value;
			}
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x001D5987 File Offset: 0x001D3B87
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x001D5994 File Offset: 0x001D3B94
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.DataType != null)
			{
				this.DataType.Accept(visitor);
			}
			if (this.Seed != null)
			{
				this.Seed.Accept(visitor);
			}
			if (this.Increment != null)
			{
				this.Increment.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002116 RID: 8470
		private DataTypeReference _dataType;

		// Token: 0x04002117 RID: 8471
		private ScalarExpression _seed;

		// Token: 0x04002118 RID: 8472
		private ScalarExpression _increment;
	}
}
