using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000330 RID: 816
	[Serializable]
	public class KillQueryNotificationSubscriptionStatement : TSqlStatement
	{
		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06003193 RID: 12691 RVA: 0x001D072F File Offset: 0x001CE92F
		// (set) Token: 0x06003194 RID: 12692 RVA: 0x001D0737 File Offset: 0x001CE937
		public Literal SubscriptionId
		{
			get
			{
				return this._subscriptionId;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._subscriptionId = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06003195 RID: 12693 RVA: 0x001D0747 File Offset: 0x001CE947
		// (set) Token: 0x06003196 RID: 12694 RVA: 0x001D074F File Offset: 0x001CE94F
		public bool All
		{
			get
			{
				return this._all;
			}
			set
			{
				this._all = value;
			}
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x001D0758 File Offset: 0x001CE958
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x001D0764 File Offset: 0x001CE964
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SubscriptionId != null)
			{
				this.SubscriptionId.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F95 RID: 8085
		private Literal _subscriptionId;

		// Token: 0x04001F96 RID: 8086
		private bool _all;
	}
}
