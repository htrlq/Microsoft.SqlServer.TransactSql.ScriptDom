using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200049A RID: 1178
	[Serializable]
	public class DropWorkloadGroupStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003A32 RID: 14898 RVA: 0x001D9068 File Offset: 0x001D7268
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A33 RID: 14899 RVA: 0x001D9074 File Offset: 0x001D7274
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
