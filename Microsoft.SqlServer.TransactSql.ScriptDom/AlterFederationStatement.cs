using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004DE RID: 1246
	[Serializable]
	public class AlterFederationStatement : TSqlStatement
	{
		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06003BB5 RID: 15285 RVA: 0x001DA8CC File Offset: 0x001D8ACC
		// (set) Token: 0x06003BB6 RID: 15286 RVA: 0x001DA8D4 File Offset: 0x001D8AD4
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

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06003BB7 RID: 15287 RVA: 0x001DA8E4 File Offset: 0x001D8AE4
		// (set) Token: 0x06003BB8 RID: 15288 RVA: 0x001DA8EC File Offset: 0x001D8AEC
		public AlterFederationKind Kind
		{
			get
			{
				return this._kind;
			}
			set
			{
				this._kind = value;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06003BB9 RID: 15289 RVA: 0x001DA8F5 File Offset: 0x001D8AF5
		// (set) Token: 0x06003BBA RID: 15290 RVA: 0x001DA8FD File Offset: 0x001D8AFD
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

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06003BBB RID: 15291 RVA: 0x001DA90D File Offset: 0x001D8B0D
		// (set) Token: 0x06003BBC RID: 15292 RVA: 0x001DA915 File Offset: 0x001D8B15
		public ScalarExpression Boundary
		{
			get
			{
				return this._boundary;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._boundary = value;
			}
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x001DA925 File Offset: 0x001D8B25
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x001DA934 File Offset: 0x001D8B34
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
			if (this.Boundary != null)
			{
				this.Boundary.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002270 RID: 8816
		private Identifier _name;

		// Token: 0x04002271 RID: 8817
		private AlterFederationKind _kind;

		// Token: 0x04002272 RID: 8818
		private Identifier _distributionName;

		// Token: 0x04002273 RID: 8819
		private ScalarExpression _boundary;
	}
}
