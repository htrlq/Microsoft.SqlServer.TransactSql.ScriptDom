using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004D9 RID: 1241
	[Serializable]
	public class AlterAvailabilityGroupAction : TSqlFragment
	{
		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06003B99 RID: 15257 RVA: 0x001DA713 File Offset: 0x001D8913
		// (set) Token: 0x06003B9A RID: 15258 RVA: 0x001DA71B File Offset: 0x001D891B
		public AlterAvailabilityGroupActionType ActionType
		{
			get
			{
				return this._actionType;
			}
			set
			{
				this._actionType = value;
			}
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x001DA724 File Offset: 0x001D8924
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x001DA730 File Offset: 0x001D8930
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002269 RID: 8809
		private AlterAvailabilityGroupActionType _actionType;
	}
}
