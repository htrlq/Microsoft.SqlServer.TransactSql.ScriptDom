using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003A5 RID: 933
	[Serializable]
	public abstract class CertificateStatementBase : TSqlStatement, IPasswordChangeOption
	{
		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06003498 RID: 13464 RVA: 0x001D36F5 File Offset: 0x001D18F5
		// (set) Token: 0x06003499 RID: 13465 RVA: 0x001D36FD File Offset: 0x001D18FD
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x0600349A RID: 13466 RVA: 0x001D370D File Offset: 0x001D190D
		// (set) Token: 0x0600349B RID: 13467 RVA: 0x001D3715 File Offset: 0x001D1915
		public OptionState ActiveForBeginDialog
		{
			get
			{
				return this._activeForBeginDialog;
			}
			set
			{
				this._activeForBeginDialog = value;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600349C RID: 13468 RVA: 0x001D371E File Offset: 0x001D191E
		// (set) Token: 0x0600349D RID: 13469 RVA: 0x001D3726 File Offset: 0x001D1926
		public Literal PrivateKeyPath
		{
			get
			{
				return this._privateKeyPath;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._privateKeyPath = value;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x001D3736 File Offset: 0x001D1936
		// (set) Token: 0x0600349F RID: 13471 RVA: 0x001D373E File Offset: 0x001D193E
		public Literal EncryptionPassword
		{
			get
			{
				return this._encryptionPassword;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._encryptionPassword = value;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060034A0 RID: 13472 RVA: 0x001D374E File Offset: 0x001D194E
		// (set) Token: 0x060034A1 RID: 13473 RVA: 0x001D3756 File Offset: 0x001D1956
		public Literal DecryptionPassword
		{
			get
			{
				return this._decryptionPassword;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._decryptionPassword = value;
			}
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x001D3768 File Offset: 0x001D1968
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.PrivateKeyPath != null)
			{
				this.PrivateKeyPath.Accept(visitor);
			}
			if (this.EncryptionPassword != null)
			{
				this.EncryptionPassword.Accept(visitor);
			}
			if (this.DecryptionPassword != null)
			{
				this.DecryptionPassword.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400207E RID: 8318
		private Identifier _name;

		// Token: 0x0400207F RID: 8319
		private OptionState _activeForBeginDialog;

		// Token: 0x04002080 RID: 8320
		private Literal _privateKeyPath;

		// Token: 0x04002081 RID: 8321
		private Literal _encryptionPassword;

		// Token: 0x04002082 RID: 8322
		private Literal _decryptionPassword;
	}
}
