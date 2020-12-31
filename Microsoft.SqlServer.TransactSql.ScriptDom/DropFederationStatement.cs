using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004DF RID: 1247
	[Serializable]
	public class DropFederationStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003BC0 RID: 15296 RVA: 0x001DA98C File Offset: 0x001D8B8C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x001DA998 File Offset: 0x001D8B98
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
