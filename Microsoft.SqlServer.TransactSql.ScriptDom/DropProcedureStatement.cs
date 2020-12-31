using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000324 RID: 804
	[Serializable]
	public class DropProcedureStatement : DropObjectsStatement
	{
		// Token: 0x06003150 RID: 12624 RVA: 0x001D0355 File Offset: 0x001CE555
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x001D0361 File Offset: 0x001CE561
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
