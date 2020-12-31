using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200006D RID: 109
	[Serializable]
	public enum BooleanComparisonType
	{
		// Token: 0x04000208 RID: 520
		Equals,
		// Token: 0x04000209 RID: 521
		GreaterThan,
		// Token: 0x0400020A RID: 522
		LessThan,
		// Token: 0x0400020B RID: 523
		GreaterThanOrEqualTo,
		// Token: 0x0400020C RID: 524
		LessThanOrEqualTo,
		// Token: 0x0400020D RID: 525
		NotEqualToBrackets,
		// Token: 0x0400020E RID: 526
		NotEqualToExclamation,
		// Token: 0x0400020F RID: 527
		NotLessThan,
		// Token: 0x04000210 RID: 528
		NotGreaterThan,
		// Token: 0x04000211 RID: 529
		LeftOuterJoin,
		// Token: 0x04000212 RID: 530
		RightOuterJoin
	}
}
