using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200041C RID: 1052
	[Serializable]
	public class DropCredentialStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003773 RID: 14195 RVA: 0x001D66CC File Offset: 0x001D48CC
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x001D66D8 File Offset: 0x001D48D8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
