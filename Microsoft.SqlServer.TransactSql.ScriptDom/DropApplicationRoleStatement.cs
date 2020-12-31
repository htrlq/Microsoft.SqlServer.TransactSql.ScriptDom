using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000411 RID: 1041
	[Serializable]
	public class DropApplicationRoleStatement : DropUnownedObjectStatement
	{
		// Token: 0x0600374A RID: 14154 RVA: 0x001D6513 File Offset: 0x001D4713
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x001D651F File Offset: 0x001D471F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
