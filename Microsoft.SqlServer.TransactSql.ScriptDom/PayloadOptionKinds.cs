using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200010D RID: 269
	[Flags]
	public enum PayloadOptionKinds
	{
		// Token: 0x04000C4D RID: 3149
		None = 0,
		// Token: 0x04000C4E RID: 3150
		WebMethod = 1,
		// Token: 0x04000C4F RID: 3151
		Batches = 2,
		// Token: 0x04000C50 RID: 3152
		Wsdl = 4,
		// Token: 0x04000C51 RID: 3153
		Sessions = 8,
		// Token: 0x04000C52 RID: 3154
		LoginType = 16,
		// Token: 0x04000C53 RID: 3155
		SessionTimeout = 32,
		// Token: 0x04000C54 RID: 3156
		Database = 64,
		// Token: 0x04000C55 RID: 3157
		Namespace = 128,
		// Token: 0x04000C56 RID: 3158
		Schema = 256,
		// Token: 0x04000C57 RID: 3159
		CharacterSet = 512,
		// Token: 0x04000C58 RID: 3160
		HeaderLimit = 1024,
		// Token: 0x04000C59 RID: 3161
		Authentication = 2048,
		// Token: 0x04000C5A RID: 3162
		Encryption = 4096,
		// Token: 0x04000C5B RID: 3163
		MessageForwarding = 8192,
		// Token: 0x04000C5C RID: 3164
		MessageForwardSize = 16384,
		// Token: 0x04000C5D RID: 3165
		Role = 32768,
		// Token: 0x04000C5E RID: 3166
		SoapOptions = 2047,
		// Token: 0x04000C5F RID: 3167
		ServiceBrokerOptions = 30720,
		// Token: 0x04000C60 RID: 3168
		DatabaseMirroringOptions = 38912
	}
}
