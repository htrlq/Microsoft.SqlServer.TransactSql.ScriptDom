using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000492 RID: 1170
	[Serializable]
	public class AlterResourcePoolStatement : ResourcePoolStatement
	{
		// Token: 0x06003A11 RID: 14865 RVA: 0x001D8EAA File Offset: 0x001D70AA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x001D8EB6 File Offset: 0x001D70B6
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
