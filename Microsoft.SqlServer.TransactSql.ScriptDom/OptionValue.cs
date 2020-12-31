using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000287 RID: 647
	[Serializable]
	public abstract class OptionValue : TSqlFragment
	{
		// Token: 0x06002DCF RID: 11727 RVA: 0x001CC817 File Offset: 0x001CAA17
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
