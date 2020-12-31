using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000459 RID: 1113
	[Serializable]
	public class BackupServiceMasterKeyStatement : BackupRestoreMasterKeyStatementBase
	{
		// Token: 0x060038EE RID: 14574 RVA: 0x001D7E34 File Offset: 0x001D6034
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x001D7E40 File Offset: 0x001D6040
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
