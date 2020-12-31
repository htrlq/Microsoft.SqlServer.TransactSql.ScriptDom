using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000310 RID: 784
	[Serializable]
	public class CloseCursorStatement : CursorStatement
	{
		// Token: 0x060030ED RID: 12525 RVA: 0x001CFCF1 File Offset: 0x001CDEF1
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x001CFCFD File Offset: 0x001CDEFD
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
