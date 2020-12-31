using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200045B RID: 1115
	[Serializable]
	public class BackupMasterKeyStatement : BackupRestoreMasterKeyStatementBase
	{
		// Token: 0x060038F6 RID: 14582 RVA: 0x001D7E7F File Offset: 0x001D607F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x001D7E8B File Offset: 0x001D608B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
