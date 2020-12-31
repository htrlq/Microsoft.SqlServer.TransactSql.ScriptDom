using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200048A RID: 1162
	[Serializable]
	public abstract class DatabaseEncryptionKeyStatement : TSqlStatement
	{
		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060039E4 RID: 14820 RVA: 0x001D8C07 File Offset: 0x001D6E07
		// (set) Token: 0x060039E5 RID: 14821 RVA: 0x001D8C0F File Offset: 0x001D6E0F
		public CryptoMechanism Encryptor
		{
			get
			{
				return this._encryptor;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._encryptor = value;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060039E6 RID: 14822 RVA: 0x001D8C1F File Offset: 0x001D6E1F
		// (set) Token: 0x060039E7 RID: 14823 RVA: 0x001D8C27 File Offset: 0x001D6E27
		public DatabaseEncryptionKeyAlgorithm Algorithm
		{
			get
			{
				return this._algorithm;
			}
			set
			{
				this._algorithm = value;
			}
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x001D8C30 File Offset: 0x001D6E30
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Encryptor != null)
			{
				this.Encryptor.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021F4 RID: 8692
		private CryptoMechanism _encryptor;

		// Token: 0x040021F5 RID: 8693
		private DatabaseEncryptionKeyAlgorithm _algorithm;
	}
}
