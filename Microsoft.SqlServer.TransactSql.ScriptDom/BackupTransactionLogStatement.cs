using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000381 RID: 897
	[Serializable]
	public class BackupTransactionLogStatement : BackupStatement
	{
		// Token: 0x060033B4 RID: 13236 RVA: 0x001D278D File Offset: 0x001D098D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x001D2799 File Offset: 0x001D0999
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
