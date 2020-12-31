using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000325 RID: 805
	[Serializable]
	public class DropFunctionStatement : DropObjectsStatement
	{
		// Token: 0x06003153 RID: 12627 RVA: 0x001D0372 File Offset: 0x001CE572
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x001D037E File Offset: 0x001CE57E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
