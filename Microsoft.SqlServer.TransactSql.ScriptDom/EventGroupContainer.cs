using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002E8 RID: 744
	[Serializable]
	public class EventGroupContainer : EventTypeGroupContainer
	{
		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06003012 RID: 12306 RVA: 0x001CEECF File Offset: 0x001CD0CF
		// (set) Token: 0x06003013 RID: 12307 RVA: 0x001CEED7 File Offset: 0x001CD0D7
		public EventNotificationEventGroup EventGroup
		{
			get
			{
				return this._eventGroup;
			}
			set
			{
				this._eventGroup = value;
			}
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x001CEEE0 File Offset: 0x001CD0E0
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x001CEEEC File Offset: 0x001CD0EC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F34 RID: 7988
		private EventNotificationEventGroup _eventGroup;
	}
}
