using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000E6 RID: 230
	[Serializable]
	public class IntegerLiteral : Literal
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000276 RID: 630 RVA: 0x000087E1 File Offset: 0x000069E1
		public override LiteralType LiteralType
		{
			get
			{
				return LiteralType.Integer;
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000087E4 File Offset: 0x000069E4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000087F0 File Offset: 0x000069F0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
