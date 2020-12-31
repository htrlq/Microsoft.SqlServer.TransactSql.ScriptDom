using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004B9 RID: 1209
	[Serializable]
	public abstract class SpatialIndexOption : TSqlFragment
	{
		// Token: 0x06003AF5 RID: 15093 RVA: 0x001D9D01 File Offset: 0x001D7F01
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
