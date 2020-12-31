using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004D6 RID: 1238
	[Serializable]
	public class SecondaryRoleReplicaOption : AvailabilityReplicaOption
	{
		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06003B8B RID: 15243 RVA: 0x001DA67A File Offset: 0x001D887A
		// (set) Token: 0x06003B8C RID: 15244 RVA: 0x001DA682 File Offset: 0x001D8882
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

		// Token: 0x06003B8D RID: 15245 RVA: 0x001DA68B File Offset: 0x001D888B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x001DA697 File Offset: 0x001D8897
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002266 RID: 8806
		private AllowConnectionsOptionKind _allowConnections;
	}
}
