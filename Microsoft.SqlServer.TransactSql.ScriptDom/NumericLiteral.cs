using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000E7 RID: 231
	[Serializable]
	public class NumericLiteral : Literal
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00008801 File Offset: 0x00006A01
		public override LiteralType LiteralType
		{
			get
			{
				return LiteralType.Numeric;
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00008805 File Offset: 0x00006A05
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00008811 File Offset: 0x00006A11
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
