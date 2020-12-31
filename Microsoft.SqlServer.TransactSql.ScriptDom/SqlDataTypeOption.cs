using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200014F RID: 335
	[Serializable]
	public enum SqlDataTypeOption
	{
		// Token: 0x04000DB4 RID: 3508
		None,
		// Token: 0x04000DB5 RID: 3509
		BigInt,
		// Token: 0x04000DB6 RID: 3510
		Int,
		// Token: 0x04000DB7 RID: 3511
		SmallInt,
		// Token: 0x04000DB8 RID: 3512
		TinyInt,
		// Token: 0x04000DB9 RID: 3513
		Bit,
		// Token: 0x04000DBA RID: 3514
		Decimal,
		// Token: 0x04000DBB RID: 3515
		Numeric,
		// Token: 0x04000DBC RID: 3516
		Money,
		// Token: 0x04000DBD RID: 3517
		SmallMoney,
		// Token: 0x04000DBE RID: 3518
		Float,
		// Token: 0x04000DBF RID: 3519
		Real,
		// Token: 0x04000DC0 RID: 3520
		DateTime,
		// Token: 0x04000DC1 RID: 3521
		SmallDateTime,
		// Token: 0x04000DC2 RID: 3522
		Char,
		// Token: 0x04000DC3 RID: 3523
		VarChar,
		// Token: 0x04000DC4 RID: 3524
		Text,
		// Token: 0x04000DC5 RID: 3525
		NChar,
		// Token: 0x04000DC6 RID: 3526
		NVarChar,
		// Token: 0x04000DC7 RID: 3527
		NText,
		// Token: 0x04000DC8 RID: 3528
		Binary,
		// Token: 0x04000DC9 RID: 3529
		VarBinary,
		// Token: 0x04000DCA RID: 3530
		Image,
		// Token: 0x04000DCB RID: 3531
		Cursor,
		// Token: 0x04000DCC RID: 3532
		Sql_Variant,
		// Token: 0x04000DCD RID: 3533
		Table,
		// Token: 0x04000DCE RID: 3534
		Timestamp,
		// Token: 0x04000DCF RID: 3535
		UniqueIdentifier,
		// Token: 0x04000DD0 RID: 3536
		Date = 29,
		// Token: 0x04000DD1 RID: 3537
		Time,
		// Token: 0x04000DD2 RID: 3538
		DateTime2,
		// Token: 0x04000DD3 RID: 3539
		DateTimeOffset,
		// Token: 0x04000DD4 RID: 3540
		Rowversion
	}
}
