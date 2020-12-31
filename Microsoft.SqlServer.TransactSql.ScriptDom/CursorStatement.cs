using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200030E RID: 782
	[Serializable]
	public abstract class CursorStatement : TSqlStatement
	{
		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060030E6 RID: 12518 RVA: 0x001CFC97 File Offset: 0x001CDE97
		// (set) Token: 0x060030E7 RID: 12519 RVA: 0x001CFC9F File Offset: 0x001CDE9F
		public CursorId Cursor
		{
			get
			{
				return this._cursor;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._cursor = value;
			}
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x001CFCAF File Offset: 0x001CDEAF
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Cursor != null)
			{
				this.Cursor.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F6D RID: 8045
		private CursorId _cursor;
	}
}
