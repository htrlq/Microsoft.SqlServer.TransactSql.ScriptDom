using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200044B RID: 1099
	[Serializable]
	public abstract class WaitForSupportedStatement : TSqlStatement
	{
		// Token: 0x06003880 RID: 14464 RVA: 0x001D76C1 File Offset: 0x001D58C1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
