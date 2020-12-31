using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000EA RID: 234
	[Serializable]
	public class BinaryLiteral : Literal
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00008862 File Offset: 0x00006A62
		public override LiteralType LiteralType
		{
			get
			{
				return LiteralType.Binary;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00008865 File Offset: 0x00006A65
		// (set) Token: 0x06000288 RID: 648 RVA: 0x0000886D File Offset: 0x00006A6D
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

		// Token: 0x06000289 RID: 649 RVA: 0x00008876 File Offset: 0x00006A76
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00008882 File Offset: 0x00006A82
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04000BB2 RID: 2994
		private bool _isLargeObject;
	}
}
