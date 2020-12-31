using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004DD RID: 1245
	[Serializable]
	public class CreateFederationStatement : TSqlStatement
	{
		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06003BAC RID: 15276 RVA: 0x001DA820 File Offset: 0x001D8A20
		// (set) Token: 0x06003BAD RID: 15277 RVA: 0x001DA828 File Offset: 0x001D8A28
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06003BAE RID: 15278 RVA: 0x001DA838 File Offset: 0x001D8A38
		// (set) Token: 0x06003BAF RID: 15279 RVA: 0x001DA840 File Offset: 0x001D8A40
		public Identifier DistributionName
		{
			get
			{
				return this._distributionName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._distributionName = value;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06003BB0 RID: 15280 RVA: 0x001DA850 File Offset: 0x001D8A50
		// (set) Token: 0x06003BB1 RID: 15281 RVA: 0x001DA858 File Offset: 0x001D8A58
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

		// Token: 0x06003BB2 RID: 15282 RVA: 0x001DA868 File Offset: 0x001D8A68
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x001DA874 File Offset: 0x001D8A74
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.DistributionName != null)
			{
				this.DistributionName.Accept(visitor);
			}
			if (this.DataType != null)
			{
				this.DataType.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400226D RID: 8813
		private Identifier _name;

		// Token: 0x0400226E RID: 8814
		private Identifier _distributionName;

		// Token: 0x0400226F RID: 8815
		private DataTypeReference _dataType;
	}
}
