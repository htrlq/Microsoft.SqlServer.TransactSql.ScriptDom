using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000EE RID: 238
	[Serializable]
	public class MaxLiteral : Literal
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00008915 File Offset: 0x00006B15
		public override LiteralType LiteralType
		{
			get
			{
				return LiteralType.Max;
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00008918 File Offset: 0x00006B18
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00008924 File Offset: 0x00006B24
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
