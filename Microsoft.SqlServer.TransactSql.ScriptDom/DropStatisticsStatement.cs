using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000322 RID: 802
	[Serializable]
	public class DropStatisticsStatement : DropChildObjectsStatement
	{
		// Token: 0x0600314A RID: 12618 RVA: 0x001D031B File Offset: 0x001CE51B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x001D0327 File Offset: 0x001CE527
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
