using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002C9 RID: 713
	[Serializable]
	public class AlterRouteStatement : RouteStatement
	{
		// Token: 0x06002F3D RID: 12093 RVA: 0x001CDF1D File Offset: 0x001CC11D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x001CDF29 File Offset: 0x001CC129
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
