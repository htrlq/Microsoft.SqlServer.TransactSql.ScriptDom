using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000E8 RID: 232
	[Serializable]
	public class RealLiteral : Literal
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00008822 File Offset: 0x00006A22
		public override LiteralType LiteralType
		{
			get
			{
				return LiteralType.Real;
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00008825 File Offset: 0x00006A25
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00008831 File Offset: 0x00006A31
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
