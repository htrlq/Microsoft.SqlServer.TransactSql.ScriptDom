using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000442 RID: 1090
	[Serializable]
	public class DropRouteStatement : DropUnownedObjectStatement
	{
		// Token: 0x0600384A RID: 14410 RVA: 0x001D735B File Offset: 0x001D555B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x001D7367 File Offset: 0x001D5567
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
