using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200048D RID: 1165
	[Serializable]
	public class DropDatabaseEncryptionKeyStatement : TSqlStatement
	{
		// Token: 0x060039F2 RID: 14834 RVA: 0x001D8CA0 File Offset: 0x001D6EA0
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x001D8CAC File Offset: 0x001D6EAC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
