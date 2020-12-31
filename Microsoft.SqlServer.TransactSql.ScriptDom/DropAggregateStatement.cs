using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200040F RID: 1039
	[Serializable]
	public class DropAggregateStatement : DropObjectsStatement
	{
		// Token: 0x06003742 RID: 14146 RVA: 0x001D64C8 File Offset: 0x001D46C8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x001D64D4 File Offset: 0x001D46D4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
