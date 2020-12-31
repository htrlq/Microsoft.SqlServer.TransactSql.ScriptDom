using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004D5 RID: 1237
	[Serializable]
	public class PrimaryRoleReplicaOption : AvailabilityReplicaOption
	{
		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06003B86 RID: 15238 RVA: 0x001DA64C File Offset: 0x001D884C
		// (set) Token: 0x06003B87 RID: 15239 RVA: 0x001DA654 File Offset: 0x001D8854
		public AllowConnectionsOptionKind AllowConnections
		{
			get
			{
				return this._allowConnections;
			}
			set
			{
				this._allowConnections = value;
			}
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x001DA65D File Offset: 0x001D885D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x001DA669 File Offset: 0x001D8869
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002265 RID: 8805
		private AllowConnectionsOptionKind _allowConnections;
	}
}
