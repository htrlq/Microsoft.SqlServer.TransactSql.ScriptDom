using System;

namespace antlr
{
	// Token: 0x02000010 RID: 16
	internal class CommonToken : Token
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00003A31 File Offset: 0x00001C31
		public CommonToken()
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003A39 File Offset: 0x00001C39
		public CommonToken(int t, string txt)
		{
			this.type_ = t;
			this.setText(txt);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003A4F File Offset: 0x00001C4F
		public CommonToken(string s)
		{
			this.text = s;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003A5E File Offset: 0x00001C5E
		public override int getLine()
		{
			return this.line;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003A66 File Offset: 0x00001C66
		public override string getText()
		{
			return this.text;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003A6E File Offset: 0x00001C6E
		public override void setLine(int l)
		{
			this.line = l;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003A77 File Offset: 0x00001C77
		public override void setText(string s)
		{
			this.text = s;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003A80 File Offset: 0x00001C80
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"[\"",
				this.getText(),
				"\",<",
				this.type_,
				">,line=",
				this.line,
				",col=",
				this.col,
				"]"
			});
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003AF6 File Offset: 0x00001CF6
		public override int getColumn()
		{
			return this.col;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003AFE File Offset: 0x00001CFE
		public override void setColumn(int c)
		{
			this.col = c;
		}

		// Token: 0x0400005D RID: 93
		public static readonly CommonToken.CommonTokenCreator Creator = new CommonToken.CommonTokenCreator();

		// Token: 0x0400005E RID: 94
		protected internal int line;

		// Token: 0x0400005F RID: 95
		protected internal string text;

		// Token: 0x04000060 RID: 96
		protected internal int col;

		// Token: 0x02000011 RID: 17
		internal class CommonTokenCreator : TokenCreator
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x060000B9 RID: 185 RVA: 0x00003B1B File Offset: 0x00001D1B
			public override string TokenTypeName
			{
				get
				{
					return typeof(CommonToken).FullName;
				}
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00003B2C File Offset: 0x00001D2C
			public override IToken Create()
			{
				return new CommonToken();
			}
		}
	}
}
