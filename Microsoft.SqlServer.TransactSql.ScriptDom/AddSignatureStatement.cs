using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000445 RID: 1093
	[Serializable]
	public class AddSignatureStatement : SignatureStatementBase
	{
		// Token: 0x06003859 RID: 14425 RVA: 0x001D743D File Offset: 0x001D563D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x001D7449 File Offset: 0x001D5649
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
