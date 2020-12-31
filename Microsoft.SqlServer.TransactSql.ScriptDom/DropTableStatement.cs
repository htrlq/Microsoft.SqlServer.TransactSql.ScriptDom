using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000323 RID: 803
	[Serializable]
	public class DropTableStatement : DropObjectsStatement
	{
		// Token: 0x0600314D RID: 12621 RVA: 0x001D0338 File Offset: 0x001CE538
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x001D0344 File Offset: 0x001CE544
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
