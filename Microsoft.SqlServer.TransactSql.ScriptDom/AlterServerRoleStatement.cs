using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002FA RID: 762
	[Serializable]
	public class AlterServerRoleStatement : AlterRoleStatement
	{
		// Token: 0x0600306C RID: 12396 RVA: 0x001CF3FB File Offset: 0x001CD5FB
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x001CF407 File Offset: 0x001CD607
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
