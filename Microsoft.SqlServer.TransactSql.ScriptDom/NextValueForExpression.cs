using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200028E RID: 654
	[Serializable]
	public class NextValueForExpression : PrimaryExpression
	{
		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x001CC9E5 File Offset: 0x001CABE5
		// (set) Token: 0x06002DF4 RID: 11764 RVA: 0x001CC9ED File Offset: 0x001CABED
		public SchemaObjectName SequenceName
		{
			get
			{
				return this._sequenceName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._sequenceName = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x001CC9FD File Offset: 0x001CABFD
		// (set) Token: 0x06002DF6 RID: 11766 RVA: 0x001CCA05 File Offset: 0x001CAC05
		public OverClause OverClause
		{
			get
			{
				return this._overClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._overClause = value;
			}
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x001CCA15 File Offset: 0x001CAC15
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x001CCA21 File Offset: 0x001CAC21
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SequenceName != null)
			{
				this.SequenceName.Accept(visitor);
			}
			if (this.OverClause != null)
			{
				this.OverClause.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E96 RID: 7830
		private SchemaObjectName _sequenceName;

		// Token: 0x04001E97 RID: 7831
		private OverClause _overClause;
	}
}
