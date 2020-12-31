using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001D3 RID: 467
	[Serializable]
	public class AlterViewStatement : ViewStatementBody
	{
		// Token: 0x06002986 RID: 10630 RVA: 0x001C795A File Offset: 0x001C5B5A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x001C7966 File Offset: 0x001C5B66
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
