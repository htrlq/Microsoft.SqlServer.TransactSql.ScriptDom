using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002F9 RID: 761
	[Serializable]
	public class CreateServerRoleStatement : CreateRoleStatement
	{
		// Token: 0x06003069 RID: 12393 RVA: 0x001CF3DE File Offset: 0x001CD5DE
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x001CF3EA File Offset: 0x001CD5EA
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
