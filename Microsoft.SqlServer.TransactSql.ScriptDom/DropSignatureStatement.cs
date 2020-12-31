using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000446 RID: 1094
	[Serializable]
	public class DropSignatureStatement : SignatureStatementBase
	{
		// Token: 0x0600385C RID: 14428 RVA: 0x001D745A File Offset: 0x001D565A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x001D7466 File Offset: 0x001D5666
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
