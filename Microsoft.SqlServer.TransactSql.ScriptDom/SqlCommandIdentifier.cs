using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000279 RID: 633
	[Serializable]
	public class SqlCommandIdentifier : Identifier
	{
		// Token: 0x06002D87 RID: 11655 RVA: 0x001CC3B9 File Offset: 0x001CA5B9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x001CC3C5 File Offset: 0x001CA5C5
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
