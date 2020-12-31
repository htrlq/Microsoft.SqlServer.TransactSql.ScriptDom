using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000477 RID: 1143
	[Serializable]
	public class DropDatabaseAuditSpecificationStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003986 RID: 14726 RVA: 0x001D873C File Offset: 0x001D693C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x001D8748 File Offset: 0x001D6948
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
