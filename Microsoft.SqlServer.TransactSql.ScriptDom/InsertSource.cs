using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200027D RID: 637
	[Serializable]
	public abstract class InsertSource : TSqlFragment
	{
		// Token: 0x06002D9C RID: 11676 RVA: 0x001CC4ED File Offset: 0x001CA6ED
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
