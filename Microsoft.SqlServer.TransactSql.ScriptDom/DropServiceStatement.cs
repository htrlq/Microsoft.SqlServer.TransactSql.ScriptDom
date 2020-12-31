using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000443 RID: 1091
	[Serializable]
	public class DropServiceStatement : DropUnownedObjectStatement
	{
		// Token: 0x0600384D RID: 14413 RVA: 0x001D7378 File Offset: 0x001D5578
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x001D7384 File Offset: 0x001D5584
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
