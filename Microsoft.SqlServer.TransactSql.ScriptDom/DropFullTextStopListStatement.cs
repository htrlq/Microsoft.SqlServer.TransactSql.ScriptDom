using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004A3 RID: 1187
	[Serializable]
	public class DropFullTextStopListStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003A6B RID: 14955 RVA: 0x001D93C4 File Offset: 0x001D75C4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A6C RID: 14956 RVA: 0x001D93D0 File Offset: 0x001D75D0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
