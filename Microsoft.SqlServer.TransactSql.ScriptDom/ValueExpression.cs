using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000D6 RID: 214
	[Serializable]
	public abstract class ValueExpression : PrimaryExpression
	{
		// Token: 0x06000257 RID: 599 RVA: 0x00008483 File Offset: 0x00006683
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
