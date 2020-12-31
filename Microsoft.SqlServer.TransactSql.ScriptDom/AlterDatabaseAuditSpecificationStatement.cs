using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000476 RID: 1142
	[Serializable]
	public class AlterDatabaseAuditSpecificationStatement : AuditSpecificationStatement
	{
		// Token: 0x06003983 RID: 14723 RVA: 0x001D871F File Offset: 0x001D691F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x001D872B File Offset: 0x001D692B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
