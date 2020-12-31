using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000483 RID: 1155
	[Serializable]
	public class OnFailureAuditOption : AuditOption
	{
		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060039BC RID: 14780 RVA: 0x001D8A4D File Offset: 0x001D6C4D
		// (set) Token: 0x060039BD RID: 14781 RVA: 0x001D8A55 File Offset: 0x001D6C55
		public AuditFailureActionType OnFailureAction
		{
			get
			{
				return this._onFailureAction;
			}
			set
			{
				this._onFailureAction = value;
			}
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x001D8A5E File Offset: 0x001D6C5E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x001D8A6A File Offset: 0x001D6C6A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021EA RID: 8682
		private AuditFailureActionType _onFailureAction;
	}
}
