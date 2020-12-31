using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004CE RID: 1230
	[Serializable]
	public class CreateAvailabilityGroupStatement : AvailabilityGroupStatement
	{
		// Token: 0x06003B63 RID: 15203 RVA: 0x001DA47A File Offset: 0x001D867A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x001DA486 File Offset: 0x001D8686
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
