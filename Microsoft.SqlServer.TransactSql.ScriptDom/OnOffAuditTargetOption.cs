using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000489 RID: 1161
	[Serializable]
	public class OnOffAuditTargetOption : AuditTargetOption
	{
		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060039DF RID: 14815 RVA: 0x001D8BD9 File Offset: 0x001D6DD9
		// (set) Token: 0x060039E0 RID: 14816 RVA: 0x001D8BE1 File Offset: 0x001D6DE1
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

		// Token: 0x060039E1 RID: 14817 RVA: 0x001D8BEA File Offset: 0x001D6DEA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x001D8BF6 File Offset: 0x001D6DF6
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021F3 RID: 8691
		private OptionState _value;
	}
}
