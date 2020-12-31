using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000D3 RID: 211
	[Serializable]
	public abstract class ScalarExpression : TSqlFragment
	{
		// Token: 0x0600024F RID: 591 RVA: 0x00008435 File Offset: 0x00006635
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
