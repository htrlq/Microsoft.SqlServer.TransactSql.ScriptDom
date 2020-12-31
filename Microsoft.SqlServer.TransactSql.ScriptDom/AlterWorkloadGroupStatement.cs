using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000499 RID: 1177
	[Serializable]
	public class AlterWorkloadGroupStatement : WorkloadGroupStatement
	{
		// Token: 0x06003A2F RID: 14895 RVA: 0x001D904B File Offset: 0x001D724B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x001D9057 File Offset: 0x001D7257
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
