using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200030F RID: 783
	[Serializable]
	public class OpenCursorStatement : CursorStatement
	{
		// Token: 0x060030EA RID: 12522 RVA: 0x001CFCD4 File Offset: 0x001CDED4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x001CFCE0 File Offset: 0x001CDEE0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
