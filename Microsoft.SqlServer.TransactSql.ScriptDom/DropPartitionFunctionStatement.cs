using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200040C RID: 1036
	[Serializable]
	public class DropPartitionFunctionStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003739 RID: 14137 RVA: 0x001D6471 File Offset: 0x001D4671
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x001D647D File Offset: 0x001D467D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
