using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000121 RID: 289
	[Flags]
	[Serializable]
	public enum RaiseErrorOptions
	{
		// Token: 0x04000CA7 RID: 3239
		None = 0,
		// Token: 0x04000CA8 RID: 3240
		Log = 1,
		// Token: 0x04000CA9 RID: 3241
		NoWait = 2,
		// Token: 0x04000CAA RID: 3242
		SetError = 4
	}
}
