using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000478 RID: 1144
	[Serializable]
	public class CreateServerAuditSpecificationStatement : AuditSpecificationStatement
	{
		// Token: 0x06003989 RID: 14729 RVA: 0x001D8759 File Offset: 0x001D6959
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x001D8765 File Offset: 0x001D6965
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
