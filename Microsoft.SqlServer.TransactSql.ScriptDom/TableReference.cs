using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001F9 RID: 505
	[Serializable]
	public abstract class TableReference : TSqlFragment
	{
		// Token: 0x06002A58 RID: 10840 RVA: 0x001C8875 File Offset: 0x001C6A75
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
