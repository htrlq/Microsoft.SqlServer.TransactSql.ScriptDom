using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000329 RID: 809
	[Serializable]
	public class DropTriggerStatement : DropObjectsStatement
	{
		// Token: 0x17000357 RID: 855
		// (get) Token: 0x0600315F RID: 12639 RVA: 0x001D03E6 File Offset: 0x001CE5E6
		// (set) Token: 0x06003160 RID: 12640 RVA: 0x001D03EE File Offset: 0x001CE5EE
		public TriggerScope TriggerScope
		{
			get
			{
				return this._triggerScope;
			}
			set
			{
				this._triggerScope = value;
			}
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x001D03F7 File Offset: 0x001CE5F7
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x001D0403 File Offset: 0x001CE603
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F85 RID: 8069
		private TriggerScope _triggerScope;
	}
}
