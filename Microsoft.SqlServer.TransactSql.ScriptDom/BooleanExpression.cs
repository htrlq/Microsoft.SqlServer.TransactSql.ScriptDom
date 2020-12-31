using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000203 RID: 515
	[Serializable]
	public abstract class BooleanExpression : TSqlFragment
	{
		// Token: 0x06002A86 RID: 10886 RVA: 0x001C8BFD File Offset: 0x001C6DFD
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
