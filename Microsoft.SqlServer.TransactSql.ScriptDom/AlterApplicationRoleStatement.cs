using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002F1 RID: 753
	[Serializable]
	public class AlterApplicationRoleStatement : ApplicationRoleStatement
	{
		// Token: 0x06003047 RID: 12359 RVA: 0x001CF206 File Offset: 0x001CD406
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x001CF212 File Offset: 0x001CD412
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
