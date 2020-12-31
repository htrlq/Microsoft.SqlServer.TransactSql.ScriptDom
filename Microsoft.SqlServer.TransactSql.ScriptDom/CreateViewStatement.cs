using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001D4 RID: 468
	[Serializable]
	public class CreateViewStatement : ViewStatementBody
	{
		// Token: 0x06002989 RID: 10633 RVA: 0x001C7977 File Offset: 0x001C5B77
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x001C7983 File Offset: 0x001C5B83
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
