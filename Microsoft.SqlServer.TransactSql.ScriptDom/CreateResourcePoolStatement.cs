using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000491 RID: 1169
	[Serializable]
	public class CreateResourcePoolStatement : ResourcePoolStatement
	{
		// Token: 0x06003A0E RID: 14862 RVA: 0x001D8E8D File Offset: 0x001D708D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x001D8E99 File Offset: 0x001D7099
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
