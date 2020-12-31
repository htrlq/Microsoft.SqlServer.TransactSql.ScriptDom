using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000473 RID: 1139
	[Serializable]
	public class DatabaseAuditAction : TSqlFragment
	{
		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06003976 RID: 14710 RVA: 0x001D86A6 File Offset: 0x001D68A6
		// (set) Token: 0x06003977 RID: 14711 RVA: 0x001D86AE File Offset: 0x001D68AE
		public DatabaseAuditActionKind ActionKind
		{
			get
			{
				return this._actionKind;
			}
			set
			{
				this._actionKind = value;
			}
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x001D86B7 File Offset: 0x001D68B7
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x001D86C3 File Offset: 0x001D68C3
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021DD RID: 8669
		private DatabaseAuditActionKind _actionKind;
	}
}
