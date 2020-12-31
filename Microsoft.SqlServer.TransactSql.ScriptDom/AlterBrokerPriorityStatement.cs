using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200049E RID: 1182
	[Serializable]
	public class AlterBrokerPriorityStatement : BrokerPriorityStatement
	{
		// Token: 0x06003A46 RID: 14918 RVA: 0x001D9195 File Offset: 0x001D7395
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x001D91A1 File Offset: 0x001D73A1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
