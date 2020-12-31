using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200033E RID: 830
	[Serializable]
	public class SetFipsFlaggerCommand : SetCommand
	{
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x060031DB RID: 12763 RVA: 0x001D0A7A File Offset: 0x001CEC7A
		// (set) Token: 0x060031DC RID: 12764 RVA: 0x001D0A82 File Offset: 0x001CEC82
		public FipsComplianceLevel ComplianceLevel
		{
			get
			{
				return this._complianceLevel;
			}
			set
			{
				this._complianceLevel = value;
			}
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x001D0A8B File Offset: 0x001CEC8B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x001D0A97 File Offset: 0x001CEC97
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FA5 RID: 8101
		private FipsComplianceLevel _complianceLevel;
	}
}
