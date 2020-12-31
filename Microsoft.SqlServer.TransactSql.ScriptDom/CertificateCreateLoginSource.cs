using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000435 RID: 1077
	[Serializable]
	public class CertificateCreateLoginSource : CreateLoginSource
	{
		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06003805 RID: 14341 RVA: 0x001D6F99 File Offset: 0x001D5199
		// (set) Token: 0x06003806 RID: 14342 RVA: 0x001D6FA1 File Offset: 0x001D51A1
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

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06003807 RID: 14343 RVA: 0x001D6FB1 File Offset: 0x001D51B1
		// (set) Token: 0x06003808 RID: 14344 RVA: 0x001D6FB9 File Offset: 0x001D51B9
		public Identifier Credential
		{
			get
			{
				return this._credential;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._credential = value;
			}
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x001D6FC9 File Offset: 0x001D51C9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x001D6FD5 File Offset: 0x001D51D5
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Certificate != null)
			{
				this.Certificate.Accept(visitor);
			}
			if (this.Credential != null)
			{
				this.Credential.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002176 RID: 8566
		private Identifier _certificate;

		// Token: 0x04002177 RID: 8567
		private Identifier _credential;
	}
}
