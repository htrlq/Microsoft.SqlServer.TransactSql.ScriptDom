using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003A1 RID: 929
	[Serializable]
	public abstract class EncryptionSource : TSqlFragment
	{
		// Token: 0x06003484 RID: 13444 RVA: 0x001D35B0 File Offset: 0x001D17B0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
