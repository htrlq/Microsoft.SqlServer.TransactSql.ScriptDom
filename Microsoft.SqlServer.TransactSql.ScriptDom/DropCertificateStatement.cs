using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200041B RID: 1051
	[Serializable]
	public class DropCertificateStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003770 RID: 14192 RVA: 0x001D66AF File Offset: 0x001D48AF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x001D66BB File Offset: 0x001D48BB
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
