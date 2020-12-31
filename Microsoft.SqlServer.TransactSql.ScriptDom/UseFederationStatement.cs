using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004E0 RID: 1248
	[Serializable]
	public class UseFederationStatement : TSqlStatement
	{
		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06003BC3 RID: 15299 RVA: 0x001DA9A9 File Offset: 0x001D8BA9
		// (set) Token: 0x06003BC4 RID: 15300 RVA: 0x001DA9B1 File Offset: 0x001D8BB1
		public Identifier FederationName
		{
			get
			{
				return this._federationName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._federationName = value;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06003BC5 RID: 15301 RVA: 0x001DA9C1 File Offset: 0x001D8BC1
		// (set) Token: 0x06003BC6 RID: 15302 RVA: 0x001DA9C9 File Offset: 0x001D8BC9
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

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06003BC7 RID: 15303 RVA: 0x001DA9D9 File Offset: 0x001D8BD9
		// (set) Token: 0x06003BC8 RID: 15304 RVA: 0x001DA9E1 File Offset: 0x001D8BE1
		public ScalarExpression Value
		{
			get
			{
				return this._value;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._value = value;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06003BC9 RID: 15305 RVA: 0x001DA9F1 File Offset: 0x001D8BF1
		// (set) Token: 0x06003BCA RID: 15306 RVA: 0x001DA9F9 File Offset: 0x001D8BF9
		public bool Filtering
		{
			get
			{
				return this._filtering;
			}
			set
			{
				this._filtering = value;
			}
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x001DAA02 File Offset: 0x001D8C02
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x001DAA10 File Offset: 0x001D8C10
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.FederationName != null)
			{
				this.FederationName.Accept(visitor);
			}
			if (this.DistributionName != null)
			{
				this.DistributionName.Accept(visitor);
			}
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002274 RID: 8820
		private Identifier _federationName;

		// Token: 0x04002275 RID: 8821
		private Identifier _distributionName;

		// Token: 0x04002276 RID: 8822
		private ScalarExpression _value;

		// Token: 0x04002277 RID: 8823
		private bool _filtering;
	}
}
