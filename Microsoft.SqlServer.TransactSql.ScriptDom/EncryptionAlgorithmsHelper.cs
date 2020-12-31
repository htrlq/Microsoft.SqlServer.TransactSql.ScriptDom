using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000A9 RID: 169
	internal class EncryptionAlgorithmsHelper : OptionsHelper<EncryptionAlgorithm>
	{
		// Token: 0x06000224 RID: 548 RVA: 0x00007D70 File Offset: 0x00005F70
		private EncryptionAlgorithmsHelper()
		{
			base.AddOptionMapping(EncryptionAlgorithm.RC2, "RC2");
			base.AddOptionMapping(EncryptionAlgorithm.RC4, "RC4");
			base.AddOptionMapping(EncryptionAlgorithm.RC4_128, "RC4_128");
			base.AddOptionMapping(EncryptionAlgorithm.Des, "DES");
			base.AddOptionMapping(EncryptionAlgorithm.TripleDes, "TRIPLE_DES");
			base.AddOptionMapping(EncryptionAlgorithm.DesX, "DESX");
			base.AddOptionMapping(EncryptionAlgorithm.Aes128, "AES_128");
			base.AddOptionMapping(EncryptionAlgorithm.Aes192, "AES_192");
			base.AddOptionMapping(EncryptionAlgorithm.Aes256, "AES_256");
			base.AddOptionMapping(EncryptionAlgorithm.Rsa512, "RSA_512");
			base.AddOptionMapping(EncryptionAlgorithm.Rsa1024, "RSA_1024");
			base.AddOptionMapping(EncryptionAlgorithm.Rsa2048, "RSA_2048");
			base.AddOptionMapping(EncryptionAlgorithm.TripleDes3Key, "TRIPLE_DES_3KEY");
		}

		// Token: 0x0400094A RID: 2378
		internal static readonly EncryptionAlgorithmsHelper Instance = new EncryptionAlgorithmsHelper();
	}
}
