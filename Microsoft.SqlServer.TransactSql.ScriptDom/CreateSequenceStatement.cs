using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000293 RID: 659
	[Serializable]
	public class CreateSequenceStatement : SequenceStatement
	{
		// Token: 0x06002E10 RID: 11792 RVA: 0x001CCBB2 File Offset: 0x001CADB2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x001CCBBE File Offset: 0x001CADBE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
