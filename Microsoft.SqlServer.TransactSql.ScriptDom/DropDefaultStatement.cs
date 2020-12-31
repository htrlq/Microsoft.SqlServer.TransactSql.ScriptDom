using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000327 RID: 807
	[Serializable]
	public class DropDefaultStatement : DropObjectsStatement
	{
		// Token: 0x06003159 RID: 12633 RVA: 0x001D03AC File Offset: 0x001CE5AC
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x001D03B8 File Offset: 0x001CE5B8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
