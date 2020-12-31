using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000316 RID: 790
	[Serializable]
	public class DeallocateCursorStatement : CursorStatement
	{
		// Token: 0x0600310F RID: 12559 RVA: 0x001CFEC9 File Offset: 0x001CE0C9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x001CFED5 File Offset: 0x001CE0D5
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
