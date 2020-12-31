using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000296 RID: 662
	[Serializable]
	public class DropSequenceStatement : DropObjectsStatement
	{
		// Token: 0x06002E19 RID: 11801 RVA: 0x001CCC45 File Offset: 0x001CAE45
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x001CCC51 File Offset: 0x001CAE51
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
