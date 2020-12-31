using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000315 RID: 789
	[Serializable]
	public class CloseMasterKeyStatement : TSqlStatement
	{
		// Token: 0x0600310C RID: 12556 RVA: 0x001CFEAC File Offset: 0x001CE0AC
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x001CFEB8 File Offset: 0x001CE0B8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
