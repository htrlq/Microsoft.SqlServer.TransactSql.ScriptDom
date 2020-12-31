using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000471 RID: 1137
	[Serializable]
	public abstract class AuditSpecificationDetail : TSqlFragment
	{
		// Token: 0x0600396D RID: 14701 RVA: 0x001D85C7 File Offset: 0x001D67C7
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
