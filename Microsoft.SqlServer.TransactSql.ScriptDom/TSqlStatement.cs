using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001C1 RID: 449
	[Serializable]
	public abstract class TSqlStatement : TSqlFragment
	{
		// Token: 0x06002918 RID: 10520 RVA: 0x001C71B9 File Offset: 0x001C53B9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
