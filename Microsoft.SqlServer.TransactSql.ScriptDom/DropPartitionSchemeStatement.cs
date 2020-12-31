using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200040D RID: 1037
	[Serializable]
	public class DropPartitionSchemeStatement : DropUnownedObjectStatement
	{
		// Token: 0x0600373C RID: 14140 RVA: 0x001D648E File Offset: 0x001D468E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x001D649A File Offset: 0x001D469A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
