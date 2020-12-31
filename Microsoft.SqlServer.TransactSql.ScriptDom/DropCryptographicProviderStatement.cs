using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004A6 RID: 1190
	[Serializable]
	public class DropCryptographicProviderStatement : DropUnownedObjectStatement
	{
		// Token: 0x06003A7E RID: 14974 RVA: 0x001D94DC File Offset: 0x001D76DC
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x001D94E8 File Offset: 0x001D76E8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
