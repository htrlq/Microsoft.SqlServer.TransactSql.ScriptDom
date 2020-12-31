using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000498 RID: 1176
	[Serializable]
	public class CreateWorkloadGroupStatement : WorkloadGroupStatement
	{
		// Token: 0x06003A2C RID: 14892 RVA: 0x001D902E File Offset: 0x001D722E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A2D RID: 14893 RVA: 0x001D903A File Offset: 0x001D723A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
