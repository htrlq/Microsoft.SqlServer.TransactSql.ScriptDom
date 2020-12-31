using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000389 RID: 905
	[Serializable]
	public class BackupEncryptionOption : BackupOption
	{
		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060033E7 RID: 13287 RVA: 0x001D2AE3 File Offset: 0x001D0CE3
		// (set) Token: 0x060033E8 RID: 13288 RVA: 0x001D2AEB File Offset: 0x001D0CEB
		public EncryptionAlgorithm Algorithm
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

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060033E9 RID: 13289 RVA: 0x001D2AF4 File Offset: 0x001D0CF4
		// (set) Token: 0x060033EA RID: 13290 RVA: 0x001D2AFC File Offset: 0x001D0CFC
		public CryptoMechanism Encryptor
		{
			get
			{
				return this._encryptor;
			}
			set
			{
				this._encryptor = value;
			}
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x001D2B05 File Offset: 0x001D0D05
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x001D2B11 File Offset: 0x001D0D11
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002048 RID: 8264
		private EncryptionAlgorithm _algorithm;

		// Token: 0x04002049 RID: 8265
		private CryptoMechanism _encryptor;
	}
}
