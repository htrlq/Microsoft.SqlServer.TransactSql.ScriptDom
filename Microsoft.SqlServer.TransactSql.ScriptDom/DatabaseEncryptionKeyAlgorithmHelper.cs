using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200008D RID: 141
	internal class DatabaseEncryptionKeyAlgorithmHelper : OptionsHelper<DatabaseEncryptionKeyAlgorithm>
	{
		// Token: 0x0600020E RID: 526 RVA: 0x00007463 File Offset: 0x00005663
		private DatabaseEncryptionKeyAlgorithmHelper()
		{
			base.AddOptionMapping(DatabaseEncryptionKeyAlgorithm.Aes128, "AES_128");
			base.AddOptionMapping(DatabaseEncryptionKeyAlgorithm.Aes192, "AES_192");
			base.AddOptionMapping(DatabaseEncryptionKeyAlgorithm.Aes256, "AES_256");
			base.AddOptionMapping(DatabaseEncryptionKeyAlgorithm.TripleDes3Key, "TRIPLE_DES_3KEY");
		}

		// Token: 0x04000835 RID: 2101
		internal static readonly DatabaseEncryptionKeyAlgorithmHelper Instance = new DatabaseEncryptionKeyAlgorithmHelper();
	}
}
