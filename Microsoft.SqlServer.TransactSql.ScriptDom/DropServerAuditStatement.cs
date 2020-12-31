using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200047E RID: 1150
	[Serializable]
	public class DropServerAuditStatement : DropUnownedObjectStatement
	{
		// Token: 0x060039A5 RID: 14757 RVA: 0x001D8904 File Offset: 0x001D6B04
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x001D8910 File Offset: 0x001D6B10
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
