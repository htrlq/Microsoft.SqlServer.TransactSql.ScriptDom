using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002F5 RID: 757
	[Serializable]
	public abstract class AlterRoleAction : TSqlFragment
	{
		// Token: 0x06003058 RID: 12376 RVA: 0x001CF2F2 File Offset: 0x001CD4F2
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
