using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003A7 RID: 935
	[Serializable]
	public class CreateCertificateStatement : CertificateStatementBase, IAuthorization
	{
		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060034AB RID: 13483 RVA: 0x001D382E File Offset: 0x001D1A2E
		// (set) Token: 0x060034AC RID: 13484 RVA: 0x001D3836 File Offset: 0x001D1A36
		public EncryptionSource CertificateSource
		{
			get
			{
				return this._certificateSource;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._certificateSource = value;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060034AD RID: 13485 RVA: 0x001D3846 File Offset: 0x001D1A46
		public IList<CertificateOption> CertificateOptions
		{
			get
			{
				return this._certificateOptions;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060034AE RID: 13486 RVA: 0x001D384E File Offset: 0x001D1A4E
		// (set) Token: 0x060034AF RID: 13487 RVA: 0x001D3856 File Offset: 0x001D1A56
		public Identifier Owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._owner = value;
			}
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x001D3866 File Offset: 0x001D1A66
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x001D3874 File Offset: 0x001D1A74
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			if (this.CertificateSource != null)
			{
				this.CertificateSource.Accept(visitor);
			}
			if (base.PrivateKeyPath != null)
			{
				base.PrivateKeyPath.Accept(visitor);
			}
			int i = 0;
			int count = this.CertificateOptions.Count;
			while (i < count)
			{
				this.CertificateOptions[i].Accept(visitor);
				i++;
			}
			if (base.EncryptionPassword != null)
			{
				base.EncryptionPassword.Accept(visitor);
			}
			if (base.DecryptionPassword != null)
			{
				base.DecryptionPassword.Accept(visitor);
			}
			if (this.Owner != null)
			{
				this.Owner.Accept(visitor);
			}
		}

		// Token: 0x04002085 RID: 8325
		private EncryptionSource _certificateSource;

		// Token: 0x04002086 RID: 8326
		private List<CertificateOption> _certificateOptions = new List<CertificateOption>();

		// Token: 0x04002087 RID: 8327
		private Identifier _owner;
	}
}
