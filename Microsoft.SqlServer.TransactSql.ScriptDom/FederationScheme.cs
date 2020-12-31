using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000376 RID: 886
	[Serializable]
	public class FederationScheme : TSqlFragment
	{
		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x0600335F RID: 13151 RVA: 0x001D2135 File Offset: 0x001D0335
		// (set) Token: 0x06003360 RID: 13152 RVA: 0x001D213D File Offset: 0x001D033D
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

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06003361 RID: 13153 RVA: 0x001D214D File Offset: 0x001D034D
		// (set) Token: 0x06003362 RID: 13154 RVA: 0x001D2155 File Offset: 0x001D0355
		public Identifier ColumnName
		{
			get
			{
				return this._columnName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._columnName = value;
			}
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x001D2165 File Offset: 0x001D0365
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x001D2171 File Offset: 0x001D0371
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.DistributionName != null)
			{
				this.DistributionName.Accept(visitor);
			}
			if (this.ColumnName != null)
			{
				this.ColumnName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400201A RID: 8218
		private Identifier _distributionName;

		// Token: 0x0400201B RID: 8219
		private Identifier _columnName;
	}
}
