using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004DC RID: 1244
	[Serializable]
	public class DropAvailabilityGroupStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003BA9 RID: 15273 RVA: 0x001DA803 File Offset: 0x001D8A03
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x001DA80F File Offset: 0x001D8A0F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
