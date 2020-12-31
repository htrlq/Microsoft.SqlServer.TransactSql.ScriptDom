using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004A9 RID: 1193
	[Serializable]
	public class CreateEventSessionStatement : EventSessionStatement
	{
		// Token: 0x06003A8E RID: 14990 RVA: 0x001D9656 File Offset: 0x001D7856
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x001D9662 File Offset: 0x001D7862
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
