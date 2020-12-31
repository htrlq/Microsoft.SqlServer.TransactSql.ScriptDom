using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200020E RID: 526
	[Serializable]
	public class ReadOnlyForClause : ForClause
	{
		// Token: 0x06002AD4 RID: 10964 RVA: 0x001C9173 File Offset: 0x001C7373
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x001C917F File Offset: 0x001C737F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
