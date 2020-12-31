using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200033C RID: 828
	[Serializable]
	public abstract class SetCommand : TSqlFragment
	{
		// Token: 0x060031D2 RID: 12754 RVA: 0x001D0A0F File Offset: 0x001CEC0F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
