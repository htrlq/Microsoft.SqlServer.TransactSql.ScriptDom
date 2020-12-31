using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002E9 RID: 745
	[Serializable]
	public class CreateEventNotificationStatement : TSqlStatement
	{
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06003017 RID: 12311 RVA: 0x001CEEFD File Offset: 0x001CD0FD
		// (set) Token: 0x06003018 RID: 12312 RVA: 0x001CEF05 File Offset: 0x001CD105
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

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06003019 RID: 12313 RVA: 0x001CEF15 File Offset: 0x001CD115
		// (set) Token: 0x0600301A RID: 12314 RVA: 0x001CEF1D File Offset: 0x001CD11D
		public EventNotificationObjectScope Scope
		{
			get
			{
				return this._scope;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._scope = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600301B RID: 12315 RVA: 0x001CEF2D File Offset: 0x001CD12D
		// (set) Token: 0x0600301C RID: 12316 RVA: 0x001CEF35 File Offset: 0x001CD135
		public bool WithFanIn
		{
			get
			{
				return this._withFanIn;
			}
			set
			{
				this._withFanIn = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600301D RID: 12317 RVA: 0x001CEF3E File Offset: 0x001CD13E
		public IList<EventTypeGroupContainer> EventTypeGroups
		{
			get
			{
				return this._eventTypeGroups;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600301E RID: 12318 RVA: 0x001CEF46 File Offset: 0x001CD146
		// (set) Token: 0x0600301F RID: 12319 RVA: 0x001CEF4E File Offset: 0x001CD14E
		public Literal BrokerService
		{
			get
			{
				return this._brokerService;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._brokerService = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06003020 RID: 12320 RVA: 0x001CEF5E File Offset: 0x001CD15E
		// (set) Token: 0x06003021 RID: 12321 RVA: 0x001CEF66 File Offset: 0x001CD166
		public Literal BrokerInstanceSpecifier
		{
			get
			{
				return this._brokerInstanceSpecifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._brokerInstanceSpecifier = value;
			}
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x001CEF76 File Offset: 0x001CD176
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x001CEF84 File Offset: 0x001CD184
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.Scope != null)
			{
				this.Scope.Accept(visitor);
			}
			int i = 0;
			int count = this.EventTypeGroups.Count;
			while (i < count)
			{
				this.EventTypeGroups[i].Accept(visitor);
				i++;
			}
			if (this.BrokerService != null)
			{
				this.BrokerService.Accept(visitor);
			}
			if (this.BrokerInstanceSpecifier != null)
			{
				this.BrokerInstanceSpecifier.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F35 RID: 7989
		private Identifier _name;

		// Token: 0x04001F36 RID: 7990
		private EventNotificationObjectScope _scope;

		// Token: 0x04001F37 RID: 7991
		private bool _withFanIn;

		// Token: 0x04001F38 RID: 7992
		private List<EventTypeGroupContainer> _eventTypeGroups = new List<EventTypeGroupContainer>();

		// Token: 0x04001F39 RID: 7993
		private Literal _brokerService;

		// Token: 0x04001F3A RID: 7994
		private Literal _brokerInstanceSpecifier;
	}
}
