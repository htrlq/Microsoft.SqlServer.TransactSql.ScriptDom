using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000328 RID: 808
	[Serializable]
	public class DropRuleStatement : DropObjectsStatement
	{
		// Token: 0x0600315C RID: 12636 RVA: 0x001D03C9 File Offset: 0x001CE5C9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x001D03D5 File Offset: 0x001CE5D5
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
