using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003C7 RID: 967
	[Serializable]
	public class AuthenticationPayloadOption : PayloadOption
	{
		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600357D RID: 13693 RVA: 0x001D456F File Offset: 0x001D276F
		// (set) Token: 0x0600357E RID: 13694 RVA: 0x001D4577 File Offset: 0x001D2777
		public AuthenticationProtocol Protocol
		{
			get
			{
				return this._protocol;
			}
			set
			{
				this._protocol = value;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600357F RID: 13695 RVA: 0x001D4580 File Offset: 0x001D2780
		// (set) Token: 0x06003580 RID: 13696 RVA: 0x001D4588 File Offset: 0x001D2788
		public Identifier Certificate
		{
			get
			{
				return this._certificate;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._certificate = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x001D4598 File Offset: 0x001D2798
		// (set) Token: 0x06003582 RID: 13698 RVA: 0x001D45A0 File Offset: 0x001D27A0
		public bool TryCertificateFirst
		{
			get
			{
				return this._tryCertificateFirst;
			}
			set
			{
				this._tryCertificateFirst = value;
			}
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x001D45A9 File Offset: 0x001D27A9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x001D45B5 File Offset: 0x001D27B5
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Certificate != null)
			{
				this.Certificate.Accept(visitor);
			}
		}

		// Token: 0x040020C3 RID: 8387
		private AuthenticationProtocol _protocol;

		// Token: 0x040020C4 RID: 8388
		private Identifier _certificate;

		// Token: 0x040020C5 RID: 8389
		private bool _tryCertificateFirst;
	}
}
