using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200045C RID: 1116
	[Serializable]
	public class RestoreMasterKeyStatement : BackupRestoreMasterKeyStatementBase
	{
		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060038F9 RID: 14585 RVA: 0x001D7E9C File Offset: 0x001D609C
		// (set) Token: 0x060038FA RID: 14586 RVA: 0x001D7EA4 File Offset: 0x001D60A4
		public bool IsForce
		{
			get
			{
				return this._isForce;
			}
			set
			{
				this._isForce = value;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x001D7EAD File Offset: 0x001D60AD
		// (set) Token: 0x060038FC RID: 14588 RVA: 0x001D7EB5 File Offset: 0x001D60B5
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

		// Token: 0x060038FD RID: 14589 RVA: 0x001D7EC5 File Offset: 0x001D60C5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x001D7ED1 File Offset: 0x001D60D1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.EncryptionPassword != null)
			{
				this.EncryptionPassword.Accept(visitor);
			}
		}

		// Token: 0x040021BB RID: 8635
		private bool _isForce;

		// Token: 0x040021BC RID: 8636
		private Literal _encryptionPassword;
	}
}
