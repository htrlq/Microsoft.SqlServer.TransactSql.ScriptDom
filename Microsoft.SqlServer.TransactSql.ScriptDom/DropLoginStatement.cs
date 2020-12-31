using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000414 RID: 1044
	[Serializable]
	public class DropLoginStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003755 RID: 14165 RVA: 0x001D6596 File Offset: 0x001D4796
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x001D65A2 File Offset: 0x001D47A2
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
