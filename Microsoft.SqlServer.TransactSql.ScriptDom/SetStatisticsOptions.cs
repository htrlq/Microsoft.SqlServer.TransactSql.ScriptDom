using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000142 RID: 322
	[Flags]
	[Serializable]
	public enum SetStatisticsOptions
	{
		// Token: 0x04000D7B RID: 3451
		None = 0,
		// Token: 0x04000D7C RID: 3452
		IO = 1,
		// Token: 0x04000D7D RID: 3453
		Profile = 2,
		// Token: 0x04000D7E RID: 3454
		Time = 4,
		// Token: 0x04000D7F RID: 3455
		Xml = 8
	}
}
