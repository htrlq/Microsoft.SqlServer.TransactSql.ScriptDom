using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001DA RID: 474
	[Serializable]
	public class AlterTriggerStatement : TriggerStatementBody
	{
		// Token: 0x060029B6 RID: 10678 RVA: 0x001C7C3A File Offset: 0x001C5E3A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x001C7C46 File Offset: 0x001C5E46
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
