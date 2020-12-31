using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000E9 RID: 233
	[Serializable]
	public class MoneyLiteral : Literal
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00008842 File Offset: 0x00006A42
		public override LiteralType LiteralType
		{
			get
			{
				return LiteralType.Money;
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00008845 File Offset: 0x00006A45
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00008851 File Offset: 0x00006A51
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
