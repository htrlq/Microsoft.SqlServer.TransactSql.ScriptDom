using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000364 RID: 868
	[Serializable]
	public class PartnerDatabaseOption : DatabaseOption
	{
		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060032D0 RID: 13008 RVA: 0x001D1847 File Offset: 0x001CFA47
		// (set) Token: 0x060032D1 RID: 13009 RVA: 0x001D184F File Offset: 0x001CFA4F
		public Literal PartnerServer
		{
			get
			{
				return this._partnerServer;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._partnerServer = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060032D2 RID: 13010 RVA: 0x001D185F File Offset: 0x001CFA5F
		// (set) Token: 0x060032D3 RID: 13011 RVA: 0x001D1867 File Offset: 0x001CFA67
		public PartnerDatabaseOptionKind PartnerOption
		{
			get
			{
				return this._partnerOption;
			}
			set
			{
				this._partnerOption = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060032D4 RID: 13012 RVA: 0x001D1870 File Offset: 0x001CFA70
		// (set) Token: 0x060032D5 RID: 13013 RVA: 0x001D1878 File Offset: 0x001CFA78
		public Literal Timeout
		{
			get
			{
				return this._timeout;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._timeout = value;
			}
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x001D1888 File Offset: 0x001CFA88
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x001D1894 File Offset: 0x001CFA94
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.PartnerServer != null)
			{
				this.PartnerServer.Accept(visitor);
			}
			if (this.Timeout != null)
			{
				this.Timeout.Accept(visitor);
			}
		}

		// Token: 0x04001FEB RID: 8171
		private Literal _partnerServer;

		// Token: 0x04001FEC RID: 8172
		private PartnerDatabaseOptionKind _partnerOption;

		// Token: 0x04001FED RID: 8173
		private Literal _timeout;
	}
}
