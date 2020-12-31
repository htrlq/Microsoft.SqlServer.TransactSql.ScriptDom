using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004CF RID: 1231
	[Serializable]
	public class AlterAvailabilityGroupStatement : AvailabilityGroupStatement
	{
		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06003B66 RID: 15206 RVA: 0x001DA497 File Offset: 0x001D8697
		// (set) Token: 0x06003B67 RID: 15207 RVA: 0x001DA49F File Offset: 0x001D869F
		public AlterAvailabilityGroupStatementType AlterAvailabilityGroupStatementType
		{
			get
			{
				return this._alterAvailabilityGroupStatementType;
			}
			set
			{
				this._alterAvailabilityGroupStatementType = value;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06003B68 RID: 15208 RVA: 0x001DA4A8 File Offset: 0x001D86A8
		// (set) Token: 0x06003B69 RID: 15209 RVA: 0x001DA4B0 File Offset: 0x001D86B0
		public AlterAvailabilityGroupAction Action
		{
			get
			{
				return this._action;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._action = value;
			}
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x001DA4C0 File Offset: 0x001D86C0
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x001DA4CC File Offset: 0x001D86CC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Action != null)
			{
				this.Action.Accept(visitor);
			}
		}

		// Token: 0x0400225D RID: 8797
		private AlterAvailabilityGroupStatementType _alterAvailabilityGroupStatementType;

		// Token: 0x0400225E RID: 8798
		private AlterAvailabilityGroupAction _action;
	}
}
