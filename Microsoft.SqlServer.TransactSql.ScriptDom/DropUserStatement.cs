using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000417 RID: 1047
	[Serializable]
	public class DropUserStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003760 RID: 14176 RVA: 0x001D6619 File Offset: 0x001D4819
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x001D6625 File Offset: 0x001D4825
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
