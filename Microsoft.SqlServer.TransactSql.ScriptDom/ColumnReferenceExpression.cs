using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200028D RID: 653
	[Serializable]
	public class ColumnReferenceExpression : PrimaryExpression
	{
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06002DEC RID: 11756 RVA: 0x001CC98B File Offset: 0x001CAB8B
		// (set) Token: 0x06002DED RID: 11757 RVA: 0x001CC993 File Offset: 0x001CAB93
		public ColumnType ColumnType
		{
			get
			{
				return this._columnType;
			}
			set
			{
				this._columnType = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06002DEE RID: 11758 RVA: 0x001CC99C File Offset: 0x001CAB9C
		// (set) Token: 0x06002DEF RID: 11759 RVA: 0x001CC9A4 File Offset: 0x001CABA4
		public MultiPartIdentifier MultiPartIdentifier
		{
			get
			{
				return this._multiPartIdentifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._multiPartIdentifier = value;
			}
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x001CC9B4 File Offset: 0x001CABB4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x001CC9C0 File Offset: 0x001CABC0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.MultiPartIdentifier != null)
			{
				this.MultiPartIdentifier.Accept(visitor);
			}
		}

		// Token: 0x04001E94 RID: 7828
		private ColumnType _columnType;

		// Token: 0x04001E95 RID: 7829
		private MultiPartIdentifier _multiPartIdentifier;
	}
}
