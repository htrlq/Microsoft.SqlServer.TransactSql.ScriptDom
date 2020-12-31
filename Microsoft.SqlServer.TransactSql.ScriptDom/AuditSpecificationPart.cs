using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000470 RID: 1136
	[Serializable]
	public class AuditSpecificationPart : TSqlFragment
	{
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06003966 RID: 14694 RVA: 0x001D856D File Offset: 0x001D676D
		// (set) Token: 0x06003967 RID: 14695 RVA: 0x001D8575 File Offset: 0x001D6775
		public bool IsDrop
		{
			get
			{
				return this._isDrop;
			}
			set
			{
				this._isDrop = value;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06003968 RID: 14696 RVA: 0x001D857E File Offset: 0x001D677E
		// (set) Token: 0x06003969 RID: 14697 RVA: 0x001D8586 File Offset: 0x001D6786
		public AuditSpecificationDetail Details
		{
			get
			{
				return this._details;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._details = value;
			}
		}

		// Token: 0x0600396A RID: 14698 RVA: 0x001D8596 File Offset: 0x001D6796
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600396B RID: 14699 RVA: 0x001D85A2 File Offset: 0x001D67A2
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Details != null)
			{
				this.Details.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021D8 RID: 8664
		private bool _isDrop;

		// Token: 0x040021D9 RID: 8665
		private AuditSpecificationDetail _details;
	}
}
