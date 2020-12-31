using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004B0 RID: 1200
	[Serializable]
	public class EventRetentionSessionOption : SessionOption
	{
		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x001D998B File Offset: 0x001D7B8B
		// (set) Token: 0x06003ABA RID: 15034 RVA: 0x001D9993 File Offset: 0x001D7B93
		public EventSessionEventRetentionModeType Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x06003ABB RID: 15035 RVA: 0x001D999C File Offset: 0x001D7B9C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x001D99A8 File Offset: 0x001D7BA8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400222D RID: 8749
		private EventSessionEventRetentionModeType _value;
	}
}
