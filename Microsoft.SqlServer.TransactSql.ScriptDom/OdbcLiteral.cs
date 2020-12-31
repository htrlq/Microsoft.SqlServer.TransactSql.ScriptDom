using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000EF RID: 239
	[Serializable]
	public class OdbcLiteral : Literal
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00008935 File Offset: 0x00006B35
		public override LiteralType LiteralType
		{
			get
			{
				return LiteralType.Odbc;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00008938 File Offset: 0x00006B38
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x00008940 File Offset: 0x00006B40
		public OdbcLiteralType OdbcLiteralType
		{
			get
			{
				return this._odbcLiteralType;
			}
			set
			{
				this._odbcLiteralType = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00008949 File Offset: 0x00006B49
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00008951 File Offset: 0x00006B51
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

		// Token: 0x060002A5 RID: 677 RVA: 0x0000895A File Offset: 0x00006B5A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00008966 File Offset: 0x00006B66
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04000BB5 RID: 2997
		private OdbcLiteralType _odbcLiteralType;

		// Token: 0x04000BB6 RID: 2998
		private bool _isNational;
	}
}
