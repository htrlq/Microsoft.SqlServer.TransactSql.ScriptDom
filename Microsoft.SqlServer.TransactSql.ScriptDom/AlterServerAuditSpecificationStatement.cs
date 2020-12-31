using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000479 RID: 1145
	[Serializable]
	public class AlterServerAuditSpecificationStatement : AuditSpecificationStatement
	{
		// Token: 0x0600398C RID: 14732 RVA: 0x001D8776 File Offset: 0x001D6976
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x001D8782 File Offset: 0x001D6982
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
