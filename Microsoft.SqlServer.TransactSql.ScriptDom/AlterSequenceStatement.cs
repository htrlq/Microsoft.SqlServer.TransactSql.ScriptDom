using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000294 RID: 660
	[Serializable]
	public class AlterSequenceStatement : SequenceStatement
	{
		// Token: 0x06002E13 RID: 11795 RVA: 0x001CCBCF File Offset: 0x001CADCF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x001CCBDB File Offset: 0x001CADDB
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
