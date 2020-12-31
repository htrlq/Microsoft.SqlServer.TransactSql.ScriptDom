using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001DB RID: 475
	[Serializable]
	public class CreateTriggerStatement : TriggerStatementBody
	{
		// Token: 0x060029B9 RID: 10681 RVA: 0x001C7C57 File Offset: 0x001C5E57
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x001C7C63 File Offset: 0x001C5E63
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
