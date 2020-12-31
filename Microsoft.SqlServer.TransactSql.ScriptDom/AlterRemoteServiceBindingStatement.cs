using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003A0 RID: 928
	[Serializable]
	public class AlterRemoteServiceBindingStatement : RemoteServiceBindingStatementBase
	{
		// Token: 0x06003481 RID: 13441 RVA: 0x001D3593 File Offset: 0x001D1793
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x001D359F File Offset: 0x001D179F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
