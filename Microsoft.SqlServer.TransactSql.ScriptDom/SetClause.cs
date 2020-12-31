using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200027A RID: 634
	[Serializable]
	public abstract class SetClause : TSqlFragment
	{
		// Token: 0x06002D8A RID: 11658 RVA: 0x001CC3D6 File Offset: 0x001CA5D6
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
