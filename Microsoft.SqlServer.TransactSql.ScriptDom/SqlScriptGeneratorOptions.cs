using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001B3 RID: 435
	public class SqlScriptGeneratorOptions
	{
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x00036D48 File Offset: 0x00034F48
		// (set) Token: 0x060010A0 RID: 4256 RVA: 0x00036D50 File Offset: 0x00034F50
		public KeywordCasing KeywordCasing
		{
			get
			{
				return this.keywordCasing;
			}
			set
			{
				this.keywordCasing = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x00036D59 File Offset: 0x00034F59
		// (set) Token: 0x060010A2 RID: 4258 RVA: 0x00036D61 File Offset: 0x00034F61
		public SqlVersion SqlVersion
		{
			get
			{
				return this.sqlVersion;
			}
			set
			{
				this.sqlVersion = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00036D6A File Offset: 0x00034F6A
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x00036D72 File Offset: 0x00034F72
		public int IndentationSize
		{
			get
			{
				return this.indentationSize;
			}
			set
			{
				if (value < 0)
				{
					this.indentationSize = 0;
					return;
				}
				this.indentationSize = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x00036D87 File Offset: 0x00034F87
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x00036D8F File Offset: 0x00034F8F
		public bool IncludeSemicolons
		{
			get
			{
				return this.includeSemicolons;
			}
			set
			{
				this.includeSemicolons = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x00036D98 File Offset: 0x00034F98
		// (set) Token: 0x060010A8 RID: 4264 RVA: 0x00036DA0 File Offset: 0x00034FA0
		public bool AlignColumnDefinitionFields
		{
			get
			{
				return this.alignColumnDefinitionFields;
			}
			set
			{
				this.alignColumnDefinitionFields = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x00036DA9 File Offset: 0x00034FA9
		// (set) Token: 0x060010AA RID: 4266 RVA: 0x00036DB1 File Offset: 0x00034FB1
		public bool NewLineBeforeFromClause
		{
			get
			{
				return this.newLineBeforeFromClause;
			}
			set
			{
				this.newLineBeforeFromClause = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x00036DBA File Offset: 0x00034FBA
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x00036DC2 File Offset: 0x00034FC2
		public bool NewLineBeforeWhereClause
		{
			get
			{
				return this.newLineBeforeWhereClause;
			}
			set
			{
				this.newLineBeforeWhereClause = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x00036DCB File Offset: 0x00034FCB
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x00036DD3 File Offset: 0x00034FD3
		public bool NewLineBeforeGroupByClause
		{
			get
			{
				return this.newLineBeforeGroupByClause;
			}
			set
			{
				this.newLineBeforeGroupByClause = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x00036DDC File Offset: 0x00034FDC
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x00036DE4 File Offset: 0x00034FE4
		public bool NewLineBeforeOrderByClause
		{
			get
			{
				return this.newLineBeforeOrderByClause;
			}
			set
			{
				this.newLineBeforeOrderByClause = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x00036DED File Offset: 0x00034FED
		// (set) Token: 0x060010B2 RID: 4274 RVA: 0x00036DF5 File Offset: 0x00034FF5
		public bool NewLineBeforeHavingClause
		{
			get
			{
				return this.newLineBeforeHavingClause;
			}
			set
			{
				this.newLineBeforeHavingClause = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x00036DFE File Offset: 0x00034FFE
		// (set) Token: 0x060010B4 RID: 4276 RVA: 0x00036E06 File Offset: 0x00035006
		public bool NewLineBeforeJoinClause
		{
			get
			{
				return this.newLineBeforeJoinClause;
			}
			set
			{
				this.newLineBeforeJoinClause = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00036E0F File Offset: 0x0003500F
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x00036E17 File Offset: 0x00035017
		public bool NewLineBeforeOffsetClause
		{
			get
			{
				return this.newLineBeforeOffsetClause;
			}
			set
			{
				this.newLineBeforeOffsetClause = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x00036E20 File Offset: 0x00035020
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x00036E28 File Offset: 0x00035028
		public bool NewLineBeforeOutputClause
		{
			get
			{
				return this.newLineBeforeOutputClause;
			}
			set
			{
				this.newLineBeforeOutputClause = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x00036E31 File Offset: 0x00035031
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x00036E39 File Offset: 0x00035039
		public bool AlignClauseBodies
		{
			get
			{
				return this.alignClauseBodies;
			}
			set
			{
				this.alignClauseBodies = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x00036E42 File Offset: 0x00035042
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x00036E4A File Offset: 0x0003504A
		public bool MultilineSelectElementsList
		{
			get
			{
				return this.multilineSelectElementsList;
			}
			set
			{
				this.multilineSelectElementsList = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x00036E53 File Offset: 0x00035053
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x00036E5B File Offset: 0x0003505B
		public bool MultilineWherePredicatesList
		{
			get
			{
				return this.multilineWherePredicatesList;
			}
			set
			{
				this.multilineWherePredicatesList = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x00036E64 File Offset: 0x00035064
		// (set) Token: 0x060010C0 RID: 4288 RVA: 0x00036E6C File Offset: 0x0003506C
		public bool IndentViewBody
		{
			get
			{
				return this.indentViewBody;
			}
			set
			{
				this.indentViewBody = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x00036E75 File Offset: 0x00035075
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x00036E7D File Offset: 0x0003507D
		public bool MultilineViewColumnsList
		{
			get
			{
				return this.multilineViewColumnsList;
			}
			set
			{
				this.multilineViewColumnsList = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x00036E86 File Offset: 0x00035086
		// (set) Token: 0x060010C4 RID: 4292 RVA: 0x00036E8E File Offset: 0x0003508E
		public bool AsKeywordOnOwnLine
		{
			get
			{
				return this.asKeywordOnOwnLine;
			}
			set
			{
				this.asKeywordOnOwnLine = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00036E97 File Offset: 0x00035097
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x00036E9F File Offset: 0x0003509F
		public bool IndentSetClause
		{
			get
			{
				return this.indentSetClause;
			}
			set
			{
				this.indentSetClause = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x00036EA8 File Offset: 0x000350A8
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x00036EB0 File Offset: 0x000350B0
		public bool AlignSetClauseItem
		{
			get
			{
				return this.alignSetClauseItem;
			}
			set
			{
				this.alignSetClauseItem = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x00036EB9 File Offset: 0x000350B9
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x00036EC1 File Offset: 0x000350C1
		public bool MultilineSetClauseItems
		{
			get
			{
				return this.multilineSetClauseItems;
			}
			set
			{
				this.multilineSetClauseItems = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x00036ECA File Offset: 0x000350CA
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x00036ED2 File Offset: 0x000350D2
		public bool MultilineInsertTargetsList
		{
			get
			{
				return this.multilineInsertTargetsList;
			}
			set
			{
				this.multilineInsertTargetsList = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x00036EDB File Offset: 0x000350DB
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x00036EE3 File Offset: 0x000350E3
		public bool MultilineInsertSourcesList
		{
			get
			{
				return this.multilineInsertSourcesList;
			}
			set
			{
				this.multilineInsertSourcesList = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x00036EEC File Offset: 0x000350EC
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x00036EF4 File Offset: 0x000350F4
		public bool NewLineBeforeOpenParenthesisInMultilineList
		{
			get
			{
				return this.newLineBeforeOpenParenthesisInMultilineList;
			}
			set
			{
				this.newLineBeforeOpenParenthesisInMultilineList = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x00036EFD File Offset: 0x000350FD
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x00036F05 File Offset: 0x00035105
		public bool NewLineBeforeCloseParenthesisInMultilineList
		{
			get
			{
				return this.newLineBeforeCloseParenthesisInMultilineList;
			}
			set
			{
				this.newLineBeforeCloseParenthesisInMultilineList = value;
			}
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00036F10 File Offset: 0x00035110
		public void Reset()
		{
			this.KeywordCasing = KeywordCasing.Uppercase;
			this.SqlVersion = SqlVersion.Sql90;
			this.IndentationSize = 4;
			this.IncludeSemicolons = false;
			this.AlignColumnDefinitionFields = true;
			this.NewLineBeforeFromClause = true;
			this.NewLineBeforeWhereClause = true;
			this.NewLineBeforeGroupByClause = true;
			this.NewLineBeforeOrderByClause = true;
			this.NewLineBeforeHavingClause = true;
			this.NewLineBeforeJoinClause = true;
			this.NewLineBeforeOffsetClause = true;
			this.NewLineBeforeOutputClause = true;
			this.AlignClauseBodies = true;
			this.MultilineSelectElementsList = true;
			this.MultilineWherePredicatesList = true;
			this.IndentViewBody = false;
			this.MultilineViewColumnsList = true;
			this.AsKeywordOnOwnLine = true;
			this.IndentSetClause = false;
			this.AlignSetClauseItem = true;
			this.MultilineSetClauseItems = true;
			this.MultilineInsertTargetsList = true;
			this.MultilineInsertSourcesList = true;
			this.NewLineBeforeOpenParenthesisInMultilineList = false;
			this.NewLineBeforeCloseParenthesisInMultilineList = true;
		}

		// Token: 0x04001147 RID: 4423
		private const KeywordCasing DefaultKeywordCasing = KeywordCasing.Uppercase;

		// Token: 0x04001148 RID: 4424
		private const SqlVersion DefaultSqlVersion = SqlVersion.Sql90;

		// Token: 0x04001149 RID: 4425
		private const int DefaultIndentationSize = 4;

		// Token: 0x0400114A RID: 4426
		private const bool DefaultIncludeSemicolons = false;

		// Token: 0x0400114B RID: 4427
		private const bool DefaultAlignColumnDefinitionFields = true;

		// Token: 0x0400114C RID: 4428
		private const bool DefaultNewLineBeforeFromClause = true;

		// Token: 0x0400114D RID: 4429
		private const bool DefaultNewLineBeforeWhereClause = true;

		// Token: 0x0400114E RID: 4430
		private const bool DefaultNewLineBeforeGroupByClause = true;

		// Token: 0x0400114F RID: 4431
		private const bool DefaultNewLineBeforeOrderByClause = true;

		// Token: 0x04001150 RID: 4432
		private const bool DefaultNewLineBeforeHavingClause = true;

		// Token: 0x04001151 RID: 4433
		private const bool DefaultNewLineBeforeJoinClause = true;

		// Token: 0x04001152 RID: 4434
		private const bool DefaultNewLineBeforeOffsetClause = true;

		// Token: 0x04001153 RID: 4435
		private const bool DefaultNewLineBeforeOutputClause = true;

		// Token: 0x04001154 RID: 4436
		private const bool DefaultAlignClauseBodies = true;

		// Token: 0x04001155 RID: 4437
		private const bool DefaultMultilineSelectElementsList = true;

		// Token: 0x04001156 RID: 4438
		private const bool DefaultMultilineWherePredicatesList = true;

		// Token: 0x04001157 RID: 4439
		private const bool DefaultIndentViewBody = false;

		// Token: 0x04001158 RID: 4440
		private const bool DefaultMultilineViewColumnsList = true;

		// Token: 0x04001159 RID: 4441
		private const bool DefaultAsKeywordOnOwnLine = true;

		// Token: 0x0400115A RID: 4442
		private const bool DefaultIndentSetClause = false;

		// Token: 0x0400115B RID: 4443
		private const bool DefaultAlignSetClauseItem = true;

		// Token: 0x0400115C RID: 4444
		private const bool DefaultMultilineSetClauseItems = true;

		// Token: 0x0400115D RID: 4445
		private const bool DefaultMultilineInsertTargetsList = true;

		// Token: 0x0400115E RID: 4446
		private const bool DefaultMultilineInsertSourcesList = true;

		// Token: 0x0400115F RID: 4447
		private const bool DefaultNewLineBeforeOpenParenthesisInMultilineList = false;

		// Token: 0x04001160 RID: 4448
		private const bool DefaultNewLineBeforeCloseParenthesisInMultilineList = true;

		// Token: 0x04001161 RID: 4449
		private const int MinIndentationSize = 0;

		// Token: 0x04001162 RID: 4450
		private KeywordCasing keywordCasing = KeywordCasing.Uppercase;

		// Token: 0x04001163 RID: 4451
		private SqlVersion sqlVersion;

		// Token: 0x04001164 RID: 4452
		private int indentationSize = 4;

		// Token: 0x04001165 RID: 4453
		private bool includeSemicolons;

		// Token: 0x04001166 RID: 4454
		private bool alignColumnDefinitionFields = true;

		// Token: 0x04001167 RID: 4455
		private bool newLineBeforeFromClause = true;

		// Token: 0x04001168 RID: 4456
		private bool newLineBeforeWhereClause = true;

		// Token: 0x04001169 RID: 4457
		private bool newLineBeforeGroupByClause = true;

		// Token: 0x0400116A RID: 4458
		private bool newLineBeforeOrderByClause = true;

		// Token: 0x0400116B RID: 4459
		private bool newLineBeforeHavingClause = true;

		// Token: 0x0400116C RID: 4460
		private bool newLineBeforeJoinClause = true;

		// Token: 0x0400116D RID: 4461
		private bool newLineBeforeOffsetClause = true;

		// Token: 0x0400116E RID: 4462
		private bool newLineBeforeOutputClause = true;

		// Token: 0x0400116F RID: 4463
		private bool alignClauseBodies = true;

		// Token: 0x04001170 RID: 4464
		private bool multilineSelectElementsList = true;

		// Token: 0x04001171 RID: 4465
		private bool multilineWherePredicatesList = true;

		// Token: 0x04001172 RID: 4466
		private bool indentViewBody;

		// Token: 0x04001173 RID: 4467
		private bool multilineViewColumnsList = true;

		// Token: 0x04001174 RID: 4468
		private bool asKeywordOnOwnLine = true;

		// Token: 0x04001175 RID: 4469
		private bool indentSetClause;

		// Token: 0x04001176 RID: 4470
		private bool alignSetClauseItem = true;

		// Token: 0x04001177 RID: 4471
		private bool multilineSetClauseItems = true;

		// Token: 0x04001178 RID: 4472
		private bool multilineInsertTargetsList = true;

		// Token: 0x04001179 RID: 4473
		private bool multilineInsertSourcesList = true;

		// Token: 0x0400117A RID: 4474
		private bool newLineBeforeOpenParenthesisInMultilineList;

		// Token: 0x0400117B RID: 4475
		private bool newLineBeforeCloseParenthesisInMultilineList = true;
	}
}
