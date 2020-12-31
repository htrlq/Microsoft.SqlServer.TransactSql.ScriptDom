using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000ED RID: 237
	[Serializable]
	public class DefaultLiteral : Literal
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000298 RID: 664 RVA: 0x000088F5 File Offset: 0x00006AF5
		public override LiteralType LiteralType
		{
			get
			{
				return LiteralType.Default;
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000088F8 File Offset: 0x00006AF8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00008904 File Offset: 0x00006B04
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
