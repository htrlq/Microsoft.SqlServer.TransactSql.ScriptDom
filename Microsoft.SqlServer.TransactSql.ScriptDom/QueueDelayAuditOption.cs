using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000481 RID: 1153
	[Serializable]
	public class QueueDelayAuditOption : AuditOption
	{
		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060039B2 RID: 14770 RVA: 0x001D89BB File Offset: 0x001D6BBB
		// (set) Token: 0x060039B3 RID: 14771 RVA: 0x001D89C3 File Offset: 0x001D6BC3
		public Literal Delay
		{
			get
			{
				return this._delay;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._delay = value;
			}
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x001D89D3 File Offset: 0x001D6BD3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x001D89DF File Offset: 0x001D6BDF
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Delay != null)
			{
				this.Delay.Accept(visitor);
			}
		}

		// Token: 0x040021E8 RID: 8680
		private Literal _delay;
	}
}
