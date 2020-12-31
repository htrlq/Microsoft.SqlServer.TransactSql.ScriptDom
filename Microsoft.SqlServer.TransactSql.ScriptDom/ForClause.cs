using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200020C RID: 524
	[Serializable]
	public abstract class ForClause : TSqlFragment
	{
		// Token: 0x06002ACF RID: 10959 RVA: 0x001C9145 File Offset: 0x001C7345
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
