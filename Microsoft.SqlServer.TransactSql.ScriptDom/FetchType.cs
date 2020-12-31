using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000317 RID: 791
	[Serializable]
	public class FetchType : TSqlFragment
	{
		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06003112 RID: 12562 RVA: 0x001CFEE6 File Offset: 0x001CE0E6
		// (set) Token: 0x06003113 RID: 12563 RVA: 0x001CFEEE File Offset: 0x001CE0EE
		public FetchOrientation Orientation
		{
			get
			{
				return this._orientation;
			}
			set
			{
				this._orientation = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06003114 RID: 12564 RVA: 0x001CFEF7 File Offset: 0x001CE0F7
		// (set) Token: 0x06003115 RID: 12565 RVA: 0x001CFEFF File Offset: 0x001CE0FF
		public ScalarExpression RowOffset
		{
			get
			{
				return this._rowOffset;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._rowOffset = value;
			}
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x001CFF0F File Offset: 0x001CE10F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x001CFF1B File Offset: 0x001CE11B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.RowOffset != null)
			{
				this.RowOffset.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F76 RID: 8054
		private FetchOrientation _orientation;

		// Token: 0x04001F77 RID: 8055
		private ScalarExpression _rowOffset;
	}
}
