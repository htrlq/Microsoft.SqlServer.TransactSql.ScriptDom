using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001B2 RID: 434
	public enum TSqlTokenType
	{
		// Token: 0x04001059 RID: 4185
		EndOfFile = 1,
		// Token: 0x0400105A RID: 4186
		None = 0,
		// Token: 0x0400105B RID: 4187
		Add = 4,
		// Token: 0x0400105C RID: 4188
		All,
		// Token: 0x0400105D RID: 4189
		Alter,
		// Token: 0x0400105E RID: 4190
		And,
		// Token: 0x0400105F RID: 4191
		Any,
		// Token: 0x04001060 RID: 4192
		As,
		// Token: 0x04001061 RID: 4193
		Asc,
		// Token: 0x04001062 RID: 4194
		Authorization,
		// Token: 0x04001063 RID: 4195
		Backup,
		// Token: 0x04001064 RID: 4196
		Begin,
		// Token: 0x04001065 RID: 4197
		Between,
		// Token: 0x04001066 RID: 4198
		Break,
		// Token: 0x04001067 RID: 4199
		Browse,
		// Token: 0x04001068 RID: 4200
		Bulk,
		// Token: 0x04001069 RID: 4201
		By,
		// Token: 0x0400106A RID: 4202
		Cascade,
		// Token: 0x0400106B RID: 4203
		Case,
		// Token: 0x0400106C RID: 4204
		Check,
		// Token: 0x0400106D RID: 4205
		Checkpoint,
		// Token: 0x0400106E RID: 4206
		Close,
		// Token: 0x0400106F RID: 4207
		Clustered,
		// Token: 0x04001070 RID: 4208
		Coalesce,
		// Token: 0x04001071 RID: 4209
		Collate,
		// Token: 0x04001072 RID: 4210
		Column,
		// Token: 0x04001073 RID: 4211
		Commit,
		// Token: 0x04001074 RID: 4212
		Compute,
		// Token: 0x04001075 RID: 4213
		Constraint,
		// Token: 0x04001076 RID: 4214
		Contains,
		// Token: 0x04001077 RID: 4215
		ContainsTable,
		// Token: 0x04001078 RID: 4216
		Continue,
		// Token: 0x04001079 RID: 4217
		Convert,
		// Token: 0x0400107A RID: 4218
		Create,
		// Token: 0x0400107B RID: 4219
		Cross,
		// Token: 0x0400107C RID: 4220
		Current,
		// Token: 0x0400107D RID: 4221
		CurrentDate,
		// Token: 0x0400107E RID: 4222
		CurrentTime,
		// Token: 0x0400107F RID: 4223
		CurrentTimestamp,
		// Token: 0x04001080 RID: 4224
		CurrentUser,
		// Token: 0x04001081 RID: 4225
		Cursor,
		// Token: 0x04001082 RID: 4226
		Database,
		// Token: 0x04001083 RID: 4227
		Dbcc,
		// Token: 0x04001084 RID: 4228
		Deallocate,
		// Token: 0x04001085 RID: 4229
		Declare,
		// Token: 0x04001086 RID: 4230
		Default,
		// Token: 0x04001087 RID: 4231
		Delete,
		// Token: 0x04001088 RID: 4232
		Deny,
		// Token: 0x04001089 RID: 4233
		Desc,
		// Token: 0x0400108A RID: 4234
		Distinct,
		// Token: 0x0400108B RID: 4235
		Distributed,
		// Token: 0x0400108C RID: 4236
		Double,
		// Token: 0x0400108D RID: 4237
		Drop,
		// Token: 0x0400108E RID: 4238
		Else,
		// Token: 0x0400108F RID: 4239
		End,
		// Token: 0x04001090 RID: 4240
		Errlvl,
		// Token: 0x04001091 RID: 4241
		Escape,
		// Token: 0x04001092 RID: 4242
		Except,
		// Token: 0x04001093 RID: 4243
		Exec,
		// Token: 0x04001094 RID: 4244
		Execute,
		// Token: 0x04001095 RID: 4245
		Exists,
		// Token: 0x04001096 RID: 4246
		Exit,
		// Token: 0x04001097 RID: 4247
		Fetch,
		// Token: 0x04001098 RID: 4248
		File,
		// Token: 0x04001099 RID: 4249
		FillFactor,
		// Token: 0x0400109A RID: 4250
		For,
		// Token: 0x0400109B RID: 4251
		Foreign,
		// Token: 0x0400109C RID: 4252
		FreeText,
		// Token: 0x0400109D RID: 4253
		FreeTextTable,
		// Token: 0x0400109E RID: 4254
		From,
		// Token: 0x0400109F RID: 4255
		Full,
		// Token: 0x040010A0 RID: 4256
		Function,
		// Token: 0x040010A1 RID: 4257
		GoTo,
		// Token: 0x040010A2 RID: 4258
		Grant,
		// Token: 0x040010A3 RID: 4259
		Group,
		// Token: 0x040010A4 RID: 4260
		Having,
		// Token: 0x040010A5 RID: 4261
		HoldLock,
		// Token: 0x040010A6 RID: 4262
		Identity,
		// Token: 0x040010A7 RID: 4263
		IdentityInsert,
		// Token: 0x040010A8 RID: 4264
		IdentityColumn,
		// Token: 0x040010A9 RID: 4265
		If,
		// Token: 0x040010AA RID: 4266
		In,
		// Token: 0x040010AB RID: 4267
		Index,
		// Token: 0x040010AC RID: 4268
		Inner,
		// Token: 0x040010AD RID: 4269
		Insert,
		// Token: 0x040010AE RID: 4270
		Intersect,
		// Token: 0x040010AF RID: 4271
		Into,
		// Token: 0x040010B0 RID: 4272
		Is,
		// Token: 0x040010B1 RID: 4273
		Join,
		// Token: 0x040010B2 RID: 4274
		Key,
		// Token: 0x040010B3 RID: 4275
		Kill,
		// Token: 0x040010B4 RID: 4276
		Left,
		// Token: 0x040010B5 RID: 4277
		Like,
		// Token: 0x040010B6 RID: 4278
		LineNo,
		// Token: 0x040010B7 RID: 4279
		National,
		// Token: 0x040010B8 RID: 4280
		NoCheck,
		// Token: 0x040010B9 RID: 4281
		NonClustered,
		// Token: 0x040010BA RID: 4282
		Not,
		// Token: 0x040010BB RID: 4283
		Null,
		// Token: 0x040010BC RID: 4284
		NullIf,
		// Token: 0x040010BD RID: 4285
		Of,
		// Token: 0x040010BE RID: 4286
		Off,
		// Token: 0x040010BF RID: 4287
		Offsets,
		// Token: 0x040010C0 RID: 4288
		On,
		// Token: 0x040010C1 RID: 4289
		Open,
		// Token: 0x040010C2 RID: 4290
		OpenDataSource,
		// Token: 0x040010C3 RID: 4291
		OpenQuery,
		// Token: 0x040010C4 RID: 4292
		OpenRowSet,
		// Token: 0x040010C5 RID: 4293
		OpenXml,
		// Token: 0x040010C6 RID: 4294
		Option,
		// Token: 0x040010C7 RID: 4295
		Or,
		// Token: 0x040010C8 RID: 4296
		Order,
		// Token: 0x040010C9 RID: 4297
		Outer,
		// Token: 0x040010CA RID: 4298
		Over,
		// Token: 0x040010CB RID: 4299
		Percent,
		// Token: 0x040010CC RID: 4300
		Plan,
		// Token: 0x040010CD RID: 4301
		Primary,
		// Token: 0x040010CE RID: 4302
		Print,
		// Token: 0x040010CF RID: 4303
		Proc,
		// Token: 0x040010D0 RID: 4304
		Procedure,
		// Token: 0x040010D1 RID: 4305
		Public,
		// Token: 0x040010D2 RID: 4306
		Raiserror,
		// Token: 0x040010D3 RID: 4307
		Read,
		// Token: 0x040010D4 RID: 4308
		ReadText,
		// Token: 0x040010D5 RID: 4309
		Reconfigure,
		// Token: 0x040010D6 RID: 4310
		References,
		// Token: 0x040010D7 RID: 4311
		Replication,
		// Token: 0x040010D8 RID: 4312
		Restore,
		// Token: 0x040010D9 RID: 4313
		Restrict,
		// Token: 0x040010DA RID: 4314
		Return,
		// Token: 0x040010DB RID: 4315
		Revoke,
		// Token: 0x040010DC RID: 4316
		Right,
		// Token: 0x040010DD RID: 4317
		Rollback,
		// Token: 0x040010DE RID: 4318
		RowCount,
		// Token: 0x040010DF RID: 4319
		RowGuidColumn,
		// Token: 0x040010E0 RID: 4320
		Rule,
		// Token: 0x040010E1 RID: 4321
		Save,
		// Token: 0x040010E2 RID: 4322
		Schema,
		// Token: 0x040010E3 RID: 4323
		Select,
		// Token: 0x040010E4 RID: 4324
		SessionUser,
		// Token: 0x040010E5 RID: 4325
		Set,
		// Token: 0x040010E6 RID: 4326
		SetUser,
		// Token: 0x040010E7 RID: 4327
		Shutdown,
		// Token: 0x040010E8 RID: 4328
		Some,
		// Token: 0x040010E9 RID: 4329
		Statistics,
		// Token: 0x040010EA RID: 4330
		SystemUser,
		// Token: 0x040010EB RID: 4331
		Table,
		// Token: 0x040010EC RID: 4332
		TextSize,
		// Token: 0x040010ED RID: 4333
		Then,
		// Token: 0x040010EE RID: 4334
		To,
		// Token: 0x040010EF RID: 4335
		Top,
		// Token: 0x040010F0 RID: 4336
		Tran,
		// Token: 0x040010F1 RID: 4337
		Transaction,
		// Token: 0x040010F2 RID: 4338
		Trigger,
		// Token: 0x040010F3 RID: 4339
		Truncate,
		// Token: 0x040010F4 RID: 4340
		TSEqual,
		// Token: 0x040010F5 RID: 4341
		Union,
		// Token: 0x040010F6 RID: 4342
		Unique,
		// Token: 0x040010F7 RID: 4343
		Update,
		// Token: 0x040010F8 RID: 4344
		UpdateText,
		// Token: 0x040010F9 RID: 4345
		Use,
		// Token: 0x040010FA RID: 4346
		User,
		// Token: 0x040010FB RID: 4347
		Values,
		// Token: 0x040010FC RID: 4348
		Varying,
		// Token: 0x040010FD RID: 4349
		View,
		// Token: 0x040010FE RID: 4350
		WaitFor,
		// Token: 0x040010FF RID: 4351
		When,
		// Token: 0x04001100 RID: 4352
		Where,
		// Token: 0x04001101 RID: 4353
		While,
		// Token: 0x04001102 RID: 4354
		With,
		// Token: 0x04001103 RID: 4355
		WriteText,
		// Token: 0x04001104 RID: 4356
		Disk,
		// Token: 0x04001105 RID: 4357
		Precision,
		// Token: 0x04001106 RID: 4358
		External,
		// Token: 0x04001107 RID: 4359
		Revert,
		// Token: 0x04001108 RID: 4360
		Pivot,
		// Token: 0x04001109 RID: 4361
		Unpivot,
		// Token: 0x0400110A RID: 4362
		TableSample,
		// Token: 0x0400110B RID: 4363
		Dump,
		// Token: 0x0400110C RID: 4364
		Load,
		// Token: 0x0400110D RID: 4365
		Merge,
		// Token: 0x0400110E RID: 4366
		StopList,
		// Token: 0x0400110F RID: 4367
		SemanticKeyPhraseTable,
		// Token: 0x04001110 RID: 4368
		SemanticSimilarityTable,
		// Token: 0x04001111 RID: 4369
		SemanticSimilarityDetailsTable,
		// Token: 0x04001112 RID: 4370
		TryConvert,
		// Token: 0x04001113 RID: 4371
		Bang,
		// Token: 0x04001114 RID: 4372
		PercentSign,
		// Token: 0x04001115 RID: 4373
		Ampersand,
		// Token: 0x04001116 RID: 4374
		LeftParenthesis,
		// Token: 0x04001117 RID: 4375
		RightParenthesis,
		// Token: 0x04001118 RID: 4376
		LeftCurly,
		// Token: 0x04001119 RID: 4377
		RightCurly,
		// Token: 0x0400111A RID: 4378
		Star,
		// Token: 0x0400111B RID: 4379
		MultiplyEquals,
		// Token: 0x0400111C RID: 4380
		Plus,
		// Token: 0x0400111D RID: 4381
		Comma,
		// Token: 0x0400111E RID: 4382
		Minus,
		// Token: 0x0400111F RID: 4383
		Dot,
		// Token: 0x04001120 RID: 4384
		Divide,
		// Token: 0x04001121 RID: 4385
		Colon,
		// Token: 0x04001122 RID: 4386
		DoubleColon,
		// Token: 0x04001123 RID: 4387
		Semicolon,
		// Token: 0x04001124 RID: 4388
		LessThan,
		// Token: 0x04001125 RID: 4389
		EqualsSign,
		// Token: 0x04001126 RID: 4390
		RightOuterJoin,
		// Token: 0x04001127 RID: 4391
		GreaterThan,
		// Token: 0x04001128 RID: 4392
		Circumflex,
		// Token: 0x04001129 RID: 4393
		VerticalLine,
		// Token: 0x0400112A RID: 4394
		Tilde,
		// Token: 0x0400112B RID: 4395
		AddEquals,
		// Token: 0x0400112C RID: 4396
		SubtractEquals,
		// Token: 0x0400112D RID: 4397
		DivideEquals,
		// Token: 0x0400112E RID: 4398
		ModEquals,
		// Token: 0x0400112F RID: 4399
		BitwiseAndEquals,
		// Token: 0x04001130 RID: 4400
		BitwiseOrEquals,
		// Token: 0x04001131 RID: 4401
		BitwiseXorEquals,
		// Token: 0x04001132 RID: 4402
		Go,
		// Token: 0x04001133 RID: 4403
		Label,
		// Token: 0x04001134 RID: 4404
		Integer,
		// Token: 0x04001135 RID: 4405
		Numeric,
		// Token: 0x04001136 RID: 4406
		Real,
		// Token: 0x04001137 RID: 4407
		HexLiteral,
		// Token: 0x04001138 RID: 4408
		Money,
		// Token: 0x04001139 RID: 4409
		SqlCommandIdentifier,
		// Token: 0x0400113A RID: 4410
		PseudoColumn,
		// Token: 0x0400113B RID: 4411
		DollarPartition,
		// Token: 0x0400113C RID: 4412
		AsciiStringOrQuotedIdentifier,
		// Token: 0x0400113D RID: 4413
		AsciiStringLiteral,
		// Token: 0x0400113E RID: 4414
		UnicodeStringLiteral,
		// Token: 0x0400113F RID: 4415
		Identifier,
		// Token: 0x04001140 RID: 4416
		QuotedIdentifier,
		// Token: 0x04001141 RID: 4417
		Variable,
		// Token: 0x04001142 RID: 4418
		OdbcInitiator,
		// Token: 0x04001143 RID: 4419
		ProcNameSemicolon,
		// Token: 0x04001144 RID: 4420
		SingleLineComment,
		// Token: 0x04001145 RID: 4421
		MultilineComment,
		// Token: 0x04001146 RID: 4422
		WhiteSpace
	}
}
