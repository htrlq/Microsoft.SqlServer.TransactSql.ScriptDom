using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000474 RID: 1140
	[Serializable]
	public class AuditActionGroupReference : AuditSpecificationDetail
	{
		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x0600397B RID: 14715 RVA: 0x001D86D4 File Offset: 0x001D68D4
		// (set) Token: 0x0600397C RID: 14716 RVA: 0x001D86DC File Offset: 0x001D68DC
		public AuditActionGroup Group
		{
			get
			{
				return this._group;
			}
			set
			{
				this._group = value;
			}
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x001D86E5 File Offset: 0x001D68E5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x001D86F1 File Offset: 0x001D68F1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021DE RID: 8670
		private AuditActionGroup _group;
	}
}
