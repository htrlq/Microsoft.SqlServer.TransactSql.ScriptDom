using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000EB RID: 235
	[Serializable]
	public class StringLiteral : Literal
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00008893 File Offset: 0x00006A93
		public override LiteralType LiteralType
		{
			get
			{
				return LiteralType.String;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00008896 File Offset: 0x00006A96
		// (set) Token: 0x0600028E RID: 654 RVA: 0x0000889E File Offset: 0x00006A9E
		public bool IsNational
		{
			get
			{
				return this._isNational;
			}
			set
			{
				this._isNational = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600028F RID: 655 RVA: 0x000088A7 File Offset: 0x00006AA7
		// (set) Token: 0x06000290 RID: 656 RVA: 0x000088AF File Offset: 0x00006AAF
		public bool IsLargeObject
		{
			get
			{
				return this._isLargeObject;
			}
			set
			{
				this._isLargeObject = value;
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000088B8 File Offset: 0x00006AB8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000088C4 File Offset: 0x00006AC4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04000BB3 RID: 2995
		private bool _isNational;

		// Token: 0x04000BB4 RID: 2996
		private bool _isLargeObject;
	}
}
