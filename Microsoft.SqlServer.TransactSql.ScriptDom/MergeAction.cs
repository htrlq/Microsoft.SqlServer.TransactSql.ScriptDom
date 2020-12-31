using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200046A RID: 1130
	[Serializable]
	public abstract class MergeAction : TSqlFragment
	{
		// Token: 0x06003948 RID: 14664 RVA: 0x001D82EF File Offset: 0x001D64EF
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
