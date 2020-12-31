using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200035E RID: 862
	[Serializable]
	public class HadrAvailabilityGroupDatabaseOption : HadrDatabaseOption
	{
		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060032B0 RID: 12976 RVA: 0x001D16EC File Offset: 0x001CF8EC
		// (set) Token: 0x060032B1 RID: 12977 RVA: 0x001D16F4 File Offset: 0x001CF8F4
		public Identifier GroupName
		{
			get
			{
				return this._groupName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._groupName = value;
			}
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x001D1704 File Offset: 0x001CF904
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x001D1710 File Offset: 0x001CF910
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.GroupName != null)
			{
				this.GroupName.Accept(visitor);
			}
		}

		// Token: 0x04001FE4 RID: 8164
		private Identifier _groupName;
	}
}
