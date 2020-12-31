using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003EB RID: 1003
	[Serializable]
	public abstract class GroupingSpecification : TSqlFragment
	{
		// Token: 0x0600366A RID: 13930 RVA: 0x001D55A9 File Offset: 0x001D37A9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
