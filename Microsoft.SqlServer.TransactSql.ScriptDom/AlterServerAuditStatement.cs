using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200047D RID: 1149
	[Serializable]
	public class AlterServerAuditStatement : ServerAuditStatement
	{
		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x0600399E RID: 14750 RVA: 0x001D88AA File Offset: 0x001D6AAA
		// (set) Token: 0x0600399F RID: 14751 RVA: 0x001D88B2 File Offset: 0x001D6AB2
		public Identifier NewName
		{
			get
			{
				return this._newName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._newName = value;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060039A0 RID: 14752 RVA: 0x001D88C2 File Offset: 0x001D6AC2
		// (set) Token: 0x060039A1 RID: 14753 RVA: 0x001D88CA File Offset: 0x001D6ACA
		public bool RemoveWhere
		{
			get
			{
				return this._removeWhere;
			}
			set
			{
				this._removeWhere = value;
			}
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x001D88D3 File Offset: 0x001D6AD3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x001D88DF File Offset: 0x001D6ADF
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.NewName != null)
			{
				this.NewName.Accept(visitor);
			}
		}

		// Token: 0x040021E3 RID: 8675
		private Identifier _newName;

		// Token: 0x040021E4 RID: 8676
		private bool _removeWhere;
	}
}
