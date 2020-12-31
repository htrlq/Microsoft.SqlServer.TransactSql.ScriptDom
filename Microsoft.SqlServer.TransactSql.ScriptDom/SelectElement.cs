using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003FE RID: 1022
	[Serializable]
	public abstract class SelectElement : TSqlFragment
	{
		// Token: 0x060036D5 RID: 14037 RVA: 0x001D5DF9 File Offset: 0x001D3FF9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
