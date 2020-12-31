using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000475 RID: 1141
	[Serializable]
	public class CreateDatabaseAuditSpecificationStatement : AuditSpecificationStatement
	{
		// Token: 0x06003980 RID: 14720 RVA: 0x001D8702 File Offset: 0x001D6902
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x001D870E File Offset: 0x001D690E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
