using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000247 RID: 583
	[Serializable]
	public class BreakStatement : TSqlStatement
	{
		// Token: 0x06002C4A RID: 11338 RVA: 0x001CAD28 File Offset: 0x001C8F28
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x001CAD34 File Offset: 0x001C8F34
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
