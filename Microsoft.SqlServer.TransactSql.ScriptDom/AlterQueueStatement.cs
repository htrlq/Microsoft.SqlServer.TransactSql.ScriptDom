using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002CC RID: 716
	[Serializable]
	public class AlterQueueStatement : QueueStatement
	{
		// Token: 0x06002F4A RID: 12106 RVA: 0x001CE04D File Offset: 0x001CC24D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x001CE059 File Offset: 0x001CC259
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
