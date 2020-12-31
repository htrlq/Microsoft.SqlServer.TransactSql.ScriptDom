using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003F0 RID: 1008
	[Serializable]
	public class GrandTotalGroupingSpecification : GroupingSpecification
	{
		// Token: 0x0600367D RID: 13949 RVA: 0x001D5739 File Offset: 0x001D3939
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x001D5745 File Offset: 0x001D3945
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
