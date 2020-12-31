using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003D9 RID: 985
	[Serializable]
	public class AlterServiceStatement : AlterCreateServiceStatementBase
	{
		// Token: 0x060035E8 RID: 13800 RVA: 0x001D4D03 File Offset: 0x001D2F03
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x001D4D0F File Offset: 0x001D2F0F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
