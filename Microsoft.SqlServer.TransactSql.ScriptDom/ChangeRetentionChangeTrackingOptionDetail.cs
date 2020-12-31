using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200036C RID: 876
	[Serializable]
	public class ChangeRetentionChangeTrackingOptionDetail : ChangeTrackingOptionDetail
	{
		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060032FC RID: 13052 RVA: 0x001D1A9C File Offset: 0x001CFC9C
		// (set) Token: 0x060032FD RID: 13053 RVA: 0x001D1AA4 File Offset: 0x001CFCA4
		public Literal RetentionPeriod
		{
			get
			{
				return this._retentionPeriod;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._retentionPeriod = value;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060032FE RID: 13054 RVA: 0x001D1AB4 File Offset: 0x001CFCB4
		// (set) Token: 0x060032FF RID: 13055 RVA: 0x001D1ABC File Offset: 0x001CFCBC
		public TimeUnit Unit
		{
			get
			{
				return this._unit;
			}
			set
			{
				this._unit = value;
			}
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x001D1AC5 File Offset: 0x001CFCC5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x001D1AD1 File Offset: 0x001CFCD1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.RetentionPeriod != null)
			{
				this.RetentionPeriod.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FF6 RID: 8182
		private Literal _retentionPeriod;

		// Token: 0x04001FF7 RID: 8183
		private TimeUnit _unit;
	}
}
