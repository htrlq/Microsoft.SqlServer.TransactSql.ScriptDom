using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001D8 RID: 472
	[Serializable]
	public class TriggerAction : TSqlFragment
	{
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x001C7A65 File Offset: 0x001C5C65
		// (set) Token: 0x0600299E RID: 10654 RVA: 0x001C7A6D File Offset: 0x001C5C6D
		public TriggerActionType TriggerActionType
		{
			get
			{
				return this._triggerActionType;
			}
			set
			{
				this._triggerActionType = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600299F RID: 10655 RVA: 0x001C7A76 File Offset: 0x001C5C76
		// (set) Token: 0x060029A0 RID: 10656 RVA: 0x001C7A7E File Offset: 0x001C5C7E
		public EventTypeGroupContainer EventTypeGroup
		{
			get
			{
				return this._eventTypeGroup;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._eventTypeGroup = value;
			}
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x001C7A8E File Offset: 0x001C5C8E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x001C7A9A File Offset: 0x001C5C9A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.EventTypeGroup != null)
			{
				this.EventTypeGroup.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D52 RID: 7506
		private TriggerActionType _triggerActionType;

		// Token: 0x04001D53 RID: 7507
		private EventTypeGroupContainer _eventTypeGroup;
	}
}
