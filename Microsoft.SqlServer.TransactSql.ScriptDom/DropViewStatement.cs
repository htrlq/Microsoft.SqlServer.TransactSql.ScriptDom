using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000326 RID: 806
	[Serializable]
	public class DropViewStatement : DropObjectsStatement
	{
		// Token: 0x06003156 RID: 12630 RVA: 0x001D038F File Offset: 0x001CE58F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x001D039B File Offset: 0x001CE59B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
