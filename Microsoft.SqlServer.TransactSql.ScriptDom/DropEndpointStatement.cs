using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200043E RID: 1086
	[Serializable]
	public class DropEndpointStatement : DropUnownedObjectStatement
	{
		// Token: 0x0600383C RID: 14396 RVA: 0x001D72BB File Offset: 0x001D54BB
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x001D72C7 File Offset: 0x001D54C7
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
