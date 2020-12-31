using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200043D RID: 1085
	[Serializable]
	public class DropContractStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003839 RID: 14393 RVA: 0x001D729E File Offset: 0x001D549E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x001D72AA File Offset: 0x001D54AA
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
