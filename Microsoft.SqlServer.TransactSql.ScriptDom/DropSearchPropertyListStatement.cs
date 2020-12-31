using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200042C RID: 1068
	[Serializable]
	public class DropSearchPropertyListStatement : DropUnownedObjectStatement
	{
		// Token: 0x060037D7 RID: 14295 RVA: 0x001D6CED File Offset: 0x001D4EED
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x001D6CF9 File Offset: 0x001D4EF9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
