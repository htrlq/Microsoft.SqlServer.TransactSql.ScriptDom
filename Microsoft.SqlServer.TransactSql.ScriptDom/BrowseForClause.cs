using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200020D RID: 525
	[Serializable]
	public class BrowseForClause : ForClause
	{
		// Token: 0x06002AD1 RID: 10961 RVA: 0x001C9156 File Offset: 0x001C7356
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x001C9162 File Offset: 0x001C7362
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
