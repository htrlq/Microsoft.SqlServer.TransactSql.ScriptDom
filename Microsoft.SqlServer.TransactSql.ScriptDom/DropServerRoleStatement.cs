using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002FC RID: 764
	[Serializable]
	public class DropServerRoleStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003073 RID: 12403 RVA: 0x001CF455 File Offset: 0x001CD655
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x001CF461 File Offset: 0x001CD661
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
