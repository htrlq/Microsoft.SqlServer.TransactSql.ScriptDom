using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000412 RID: 1042
	[Serializable]
	public class DropFullTextCatalogStatement : DropUnownedObjectStatement
	{
		// Token: 0x0600374D RID: 14157 RVA: 0x001D6530 File Offset: 0x001D4730
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x001D653C File Offset: 0x001D473C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
