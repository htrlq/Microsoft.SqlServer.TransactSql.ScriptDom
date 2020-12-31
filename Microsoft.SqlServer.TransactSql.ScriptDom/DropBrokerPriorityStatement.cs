using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200049F RID: 1183
	[Serializable]
	public class DropBrokerPriorityStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003A49 RID: 14921 RVA: 0x001D91B2 File Offset: 0x001D73B2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A4A RID: 14922 RVA: 0x001D91BE File Offset: 0x001D73BE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
