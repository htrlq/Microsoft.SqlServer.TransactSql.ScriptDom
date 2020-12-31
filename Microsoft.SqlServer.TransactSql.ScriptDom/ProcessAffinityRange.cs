using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004C1 RID: 1217
	[Serializable]
	public class ProcessAffinityRange : LiteralRange
	{
		// Token: 0x06003B1D RID: 15133 RVA: 0x001D9F81 File Offset: 0x001D8181
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x001D9F8D File Offset: 0x001D818D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
