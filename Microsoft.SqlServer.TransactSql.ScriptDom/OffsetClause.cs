using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000407 RID: 1031
	[Serializable]
	public class OffsetClause : TSqlFragment
	{
		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06003713 RID: 14099 RVA: 0x001D6203 File Offset: 0x001D4403
		// (set) Token: 0x06003714 RID: 14100 RVA: 0x001D620B File Offset: 0x001D440B
		public ScalarExpression OffsetExpression
		{
			get
			{
				return this._offsetExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._offsetExpression = value;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06003715 RID: 14101 RVA: 0x001D621B File Offset: 0x001D441B
		// (set) Token: 0x06003716 RID: 14102 RVA: 0x001D6223 File Offset: 0x001D4423
		public ScalarExpression FetchExpression
		{
			get
			{
				return this._fetchExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._fetchExpression = value;
			}
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x001D6233 File Offset: 0x001D4433
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x001D623F File Offset: 0x001D443F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.OffsetExpression != null)
			{
				this.OffsetExpression.Accept(visitor);
			}
			if (this.FetchExpression != null)
			{
				this.FetchExpression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400213E RID: 8510
		private ScalarExpression _offsetExpression;

		// Token: 0x0400213F RID: 8511
		private ScalarExpression _fetchExpression;
	}
}
