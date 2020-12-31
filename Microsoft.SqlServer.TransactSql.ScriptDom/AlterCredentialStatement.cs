using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003AD RID: 941
	[Serializable]
	public class AlterCredentialStatement : CredentialStatement
	{
		// Token: 0x060034D6 RID: 13526 RVA: 0x001D3B91 File Offset: 0x001D1D91
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x001D3B9D File Offset: 0x001D1D9D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
