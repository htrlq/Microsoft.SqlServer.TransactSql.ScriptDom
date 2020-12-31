using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200048B RID: 1163
	[Serializable]
	public class CreateDatabaseEncryptionKeyStatement : DatabaseEncryptionKeyStatement
	{
		// Token: 0x060039EA RID: 14826 RVA: 0x001D8C55 File Offset: 0x001D6E55
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x001D8C61 File Offset: 0x001D6E61
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
