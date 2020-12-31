using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000231 RID: 561
	[Serializable]
	public abstract class CallTarget : TSqlFragment
	{
		// Token: 0x06002BD7 RID: 11223 RVA: 0x001CA519 File Offset: 0x001C8719
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
