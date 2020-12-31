using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002E7 RID: 743
	[Serializable]
	public class EventTypeContainer : EventTypeGroupContainer
	{
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600300D RID: 12301 RVA: 0x001CEEA1 File Offset: 0x001CD0A1
		// (set) Token: 0x0600300E RID: 12302 RVA: 0x001CEEA9 File Offset: 0x001CD0A9
		public EventNotificationEventType EventType
		{
			get
			{
				return this._eventType;
			}
			set
			{
				this._eventType = value;
			}
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x001CEEB2 File Offset: 0x001CD0B2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x001CEEBE File Offset: 0x001CD0BE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F33 RID: 7987
		private EventNotificationEventType _eventType;
	}
}
