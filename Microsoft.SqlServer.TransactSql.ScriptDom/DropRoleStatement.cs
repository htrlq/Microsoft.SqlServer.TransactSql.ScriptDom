using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000415 RID: 1045
	[Serializable]
	public class DropRoleStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003758 RID: 14168 RVA: 0x001D65B3 File Offset: 0x001D47B3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x001D65BF File Offset: 0x001D47BF
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
