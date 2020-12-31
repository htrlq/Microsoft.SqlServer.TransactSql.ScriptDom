using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000EC RID: 236
	[Serializable]
	public class NullLiteral : Literal
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000294 RID: 660 RVA: 0x000088D5 File Offset: 0x00006AD5
		public override LiteralType LiteralType
		{
			get
			{
				return LiteralType.Null;
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000088D8 File Offset: 0x00006AD8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000088E4 File Offset: 0x00006AE4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
