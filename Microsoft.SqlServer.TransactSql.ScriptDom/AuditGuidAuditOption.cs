using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000482 RID: 1154
	[Serializable]
	public class AuditGuidAuditOption : AuditOption
	{
		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060039B7 RID: 14775 RVA: 0x001D8A04 File Offset: 0x001D6C04
		// (set) Token: 0x060039B8 RID: 14776 RVA: 0x001D8A0C File Offset: 0x001D6C0C
		public Literal Guid
		{
			get
			{
				return this._guid;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._guid = value;
			}
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x001D8A1C File Offset: 0x001D6C1C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x001D8A28 File Offset: 0x001D6C28
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Guid != null)
			{
				this.Guid.Accept(visitor);
			}
		}

		// Token: 0x040021E9 RID: 8681
		private Literal _guid;
	}
}
