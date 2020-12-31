using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002F0 RID: 752
	[Serializable]
	public class CreateApplicationRoleStatement : ApplicationRoleStatement
	{
		// Token: 0x06003044 RID: 12356 RVA: 0x001CF1E9 File Offset: 0x001CD3E9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x001CF1F5 File Offset: 0x001CD3F5
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
