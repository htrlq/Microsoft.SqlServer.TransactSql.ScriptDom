using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004B6 RID: 1206
	[Serializable]
	public class DropEventSessionStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003ADD RID: 15069 RVA: 0x001D9B62 File Offset: 0x001D7D62
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x001D9B6E File Offset: 0x001D7D6E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
