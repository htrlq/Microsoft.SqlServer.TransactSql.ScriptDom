using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000450 RID: 1104
	[Serializable]
	public class AlterAsymmetricKeyStatement : TSqlStatement, IPasswordChangeOption
	{
		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060038A8 RID: 14504 RVA: 0x001D79B3 File Offset: 0x001D5BB3
		// (set) Token: 0x060038A9 RID: 14505 RVA: 0x001D79BB File Offset: 0x001D5BBB
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

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060038AA RID: 14506 RVA: 0x001D79CB File Offset: 0x001D5BCB
		// (set) Token: 0x060038AB RID: 14507 RVA: 0x001D79D3 File Offset: 0x001D5BD3
		public Literal AttestedBy
		{
			get
			{
				return this._attestedBy;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._attestedBy = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060038AC RID: 14508 RVA: 0x001D79E3 File Offset: 0x001D5BE3
		// (set) Token: 0x060038AD RID: 14509 RVA: 0x001D79EB File Offset: 0x001D5BEB
		public AlterCertificateStatementKind Kind
		{
			get
			{
				return this._kind;
			}
			set
			{
				this._kind = value;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060038AE RID: 14510 RVA: 0x001D79F4 File Offset: 0x001D5BF4
		// (set) Token: 0x060038AF RID: 14511 RVA: 0x001D79FC File Offset: 0x001D5BFC
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

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060038B0 RID: 14512 RVA: 0x001D7A0C File Offset: 0x001D5C0C
		// (set) Token: 0x060038B1 RID: 14513 RVA: 0x001D7A14 File Offset: 0x001D5C14
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

		// Token: 0x060038B2 RID: 14514 RVA: 0x001D7A24 File Offset: 0x001D5C24
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x001D7A30 File Offset: 0x001D5C30
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.AttestedBy != null)
			{
				this.AttestedBy.Accept(visitor);
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

		// Token: 0x040021A3 RID: 8611
		private Identifier _name;

		// Token: 0x040021A4 RID: 8612
		private Literal _attestedBy;

		// Token: 0x040021A5 RID: 8613
		private AlterCertificateStatementKind _kind;

		// Token: 0x040021A6 RID: 8614
		private Literal _encryptionPassword;

		// Token: 0x040021A7 RID: 8615
		private Literal _decryptionPassword;
	}
}
