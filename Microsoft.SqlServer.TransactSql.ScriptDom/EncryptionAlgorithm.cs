using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000A7 RID: 167
	public enum EncryptionAlgorithm
	{
		// Token: 0x04000938 RID: 2360
		None,
		// Token: 0x04000939 RID: 2361
		RC2,
		// Token: 0x0400093A RID: 2362
		RC4,
		// Token: 0x0400093B RID: 2363
		RC4_128,
		// Token: 0x0400093C RID: 2364
		Des,
		// Token: 0x0400093D RID: 2365
		TripleDes,
		// Token: 0x0400093E RID: 2366
		DesX,
		// Token: 0x0400093F RID: 2367
		Aes128,
		// Token: 0x04000940 RID: 2368
		Aes192,
		// Token: 0x04000941 RID: 2369
		Aes256,
		// Token: 0x04000942 RID: 2370
		Rsa512,
		// Token: 0x04000943 RID: 2371
		Rsa1024,
		// Token: 0x04000944 RID: 2372
		Rsa2048,
		// Token: 0x04000945 RID: 2373
		TripleDes3Key
	}
}
