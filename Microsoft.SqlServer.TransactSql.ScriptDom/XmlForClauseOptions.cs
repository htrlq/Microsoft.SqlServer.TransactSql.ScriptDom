using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000191 RID: 401
	[Flags]
	[Serializable]
	public enum XmlForClauseOptions
	{
		// Token: 0x04000FBC RID: 4028
		None = 0,
		// Token: 0x04000FBD RID: 4029
		Raw = 1,
		// Token: 0x04000FBE RID: 4030
		Auto = 2,
		// Token: 0x04000FBF RID: 4031
		Explicit = 4,
		// Token: 0x04000FC0 RID: 4032
		Path = 8,
		// Token: 0x04000FC1 RID: 4033
		XmlData = 16,
		// Token: 0x04000FC2 RID: 4034
		XmlSchema = 32,
		// Token: 0x04000FC3 RID: 4035
		Elements = 64,
		// Token: 0x04000FC4 RID: 4036
		ElementsXsiNil = 128,
		// Token: 0x04000FC5 RID: 4037
		ElementsAbsent = 256,
		// Token: 0x04000FC6 RID: 4038
		BinaryBase64 = 512,
		// Token: 0x04000FC7 RID: 4039
		Type = 1024,
		// Token: 0x04000FC8 RID: 4040
		Root = 2048,
		// Token: 0x04000FC9 RID: 4041
		ElementsAll = 448
	}
}
