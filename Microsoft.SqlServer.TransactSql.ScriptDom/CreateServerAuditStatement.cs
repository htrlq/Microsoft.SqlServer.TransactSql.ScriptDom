using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200047C RID: 1148
	[Serializable]
	public class CreateServerAuditStatement : ServerAuditStatement
	{
		// Token: 0x0600399B RID: 14747 RVA: 0x001D888D File Offset: 0x001D6A8D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x001D8899 File Offset: 0x001D6A99
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
