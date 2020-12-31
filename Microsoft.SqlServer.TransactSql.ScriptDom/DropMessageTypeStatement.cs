using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200043F RID: 1087
	[Serializable]
	public class DropMessageTypeStatement : DropUnownedObjectStatement
	{
		// Token: 0x0600383F RID: 14399 RVA: 0x001D72D8 File Offset: 0x001D54D8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x001D72E4 File Offset: 0x001D54E4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
