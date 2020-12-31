using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000484 RID: 1156
	[Serializable]
	public class StateAuditOption : AuditOption
	{
		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060039C1 RID: 14785 RVA: 0x001D8A7B File Offset: 0x001D6C7B
		// (set) Token: 0x060039C2 RID: 14786 RVA: 0x001D8A83 File Offset: 0x001D6C83
		public OptionState Value
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

		// Token: 0x060039C3 RID: 14787 RVA: 0x001D8A8C File Offset: 0x001D6C8C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x001D8A98 File Offset: 0x001D6C98
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021EB RID: 8683
		private OptionState _value;
	}
}
