using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200040E RID: 1038
	[Serializable]
	public class DropSynonymStatement : DropObjectsStatement
	{
		// Token: 0x0600373F RID: 14143 RVA: 0x001D64AB File Offset: 0x001D46AB
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x001D64B7 File Offset: 0x001D46B7
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
