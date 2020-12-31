using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200046C RID: 1132
	[Serializable]
	public class DeleteMergeAction : MergeAction
	{
		// Token: 0x0600394E RID: 14670 RVA: 0x001D8365 File Offset: 0x001D6565
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x001D8371 File Offset: 0x001D6571
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
