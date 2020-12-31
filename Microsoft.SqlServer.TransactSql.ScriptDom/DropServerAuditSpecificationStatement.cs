using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200047A RID: 1146
	[Serializable]
	public class DropServerAuditSpecificationStatement : DropUnownedObjectStatement
	{
		// Token: 0x0600398F RID: 14735 RVA: 0x001D8793 File Offset: 0x001D6993
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x001D879F File Offset: 0x001D699F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
