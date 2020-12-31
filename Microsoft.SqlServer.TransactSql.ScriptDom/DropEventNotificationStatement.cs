using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000447 RID: 1095
	[Serializable]
	public class DropEventNotificationStatement : TSqlStatement
	{
		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x0600385F RID: 14431 RVA: 0x001D7477 File Offset: 0x001D5677
		public IList<Identifier> Notifications
		{
			get
			{
				return this._notifications;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06003860 RID: 14432 RVA: 0x001D747F File Offset: 0x001D567F
		// (set) Token: 0x06003861 RID: 14433 RVA: 0x001D7487 File Offset: 0x001D5687
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

		// Token: 0x06003862 RID: 14434 RVA: 0x001D7497 File Offset: 0x001D5697
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x001D74A4 File Offset: 0x001D56A4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Notifications.Count;
			while (i < count)
			{
				this.Notifications[i].Accept(visitor);
				i++;
			}
			if (this.Scope != null)
			{
				this.Scope.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400218A RID: 8586
		private List<Identifier> _notifications = new List<Identifier>();

		// Token: 0x0400218B RID: 8587
		private EventNotificationObjectScope _scope;
	}
}
