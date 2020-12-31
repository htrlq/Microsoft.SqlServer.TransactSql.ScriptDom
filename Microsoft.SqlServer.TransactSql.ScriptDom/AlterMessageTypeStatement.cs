using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003B0 RID: 944
	[Serializable]
	public class AlterMessageTypeStatement : MessageTypeStatementBase
	{
		// Token: 0x060034E6 RID: 13542 RVA: 0x001D3C92 File Offset: 0x001D1E92
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x001D3C9E File Offset: 0x001D1E9E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
