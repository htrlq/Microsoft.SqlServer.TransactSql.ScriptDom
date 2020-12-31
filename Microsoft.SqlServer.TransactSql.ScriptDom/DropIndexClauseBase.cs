using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200031D RID: 797
	[Serializable]
	public abstract class DropIndexClauseBase : TSqlFragment
	{
		// Token: 0x06003131 RID: 12593 RVA: 0x001D0171 File Offset: 0x001CE371
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
