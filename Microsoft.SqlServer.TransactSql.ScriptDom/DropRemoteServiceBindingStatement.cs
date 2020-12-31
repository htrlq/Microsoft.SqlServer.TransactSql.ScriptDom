using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000441 RID: 1089
	[Serializable]
	public class DropRemoteServiceBindingStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003847 RID: 14407 RVA: 0x001D733E File Offset: 0x001D553E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x001D734A File Offset: 0x001D554A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
