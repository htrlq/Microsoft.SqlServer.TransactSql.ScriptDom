using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000493 RID: 1171
	[Serializable]
	public class DropResourcePoolStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003A14 RID: 14868 RVA: 0x001D8EC7 File Offset: 0x001D70C7
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x001D8ED3 File Offset: 0x001D70D3
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
