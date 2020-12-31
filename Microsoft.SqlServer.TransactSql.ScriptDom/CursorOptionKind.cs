using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000088 RID: 136
	public enum CursorOptionKind
	{
		// Token: 0x04000818 RID: 2072
		Local,
		// Token: 0x04000819 RID: 2073
		Global,
		// Token: 0x0400081A RID: 2074
		Scroll,
		// Token: 0x0400081B RID: 2075
		ForwardOnly,
		// Token: 0x0400081C RID: 2076
		Insensitive,
		// Token: 0x0400081D RID: 2077
		Keyset,
		// Token: 0x0400081E RID: 2078
		Dynamic,
		// Token: 0x0400081F RID: 2079
		FastForward,
		// Token: 0x04000820 RID: 2080
		ScrollLocks,
		// Token: 0x04000821 RID: 2081
		Optimistic,
		// Token: 0x04000822 RID: 2082
		ReadOnly,
		// Token: 0x04000823 RID: 2083
		Static,
		// Token: 0x04000824 RID: 2084
		TypeWarning
	}
}
