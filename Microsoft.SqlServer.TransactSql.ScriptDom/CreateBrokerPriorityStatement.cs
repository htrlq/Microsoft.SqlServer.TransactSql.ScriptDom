using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200049D RID: 1181
	[Serializable]
	public class CreateBrokerPriorityStatement : BrokerPriorityStatement
	{
		// Token: 0x06003A43 RID: 14915 RVA: 0x001D9178 File Offset: 0x001D7378
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x001D9184 File Offset: 0x001D7384
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
