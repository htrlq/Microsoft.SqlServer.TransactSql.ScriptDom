using System;

namespace antlr
{
	// Token: 0x0200000F RID: 15
	internal class Token : IToken
	{
		// Token: 0x0600009D RID: 157 RVA: 0x0000396A File Offset: 0x00001B6A
		public Token()
		{
			this.type_ = 0;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003979 File Offset: 0x00001B79
		public Token(int t)
		{
			this.type_ = t;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003988 File Offset: 0x00001B88
		public Token(int t, string txt)
		{
			this.type_ = t;
			this.setText(txt);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000399E File Offset: 0x00001B9E
		public virtual int getColumn()
		{
			return 0;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000039A1 File Offset: 0x00001BA1
		public virtual int getLine()
		{
			return 0;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000039A4 File Offset: 0x00001BA4
		public virtual string getFilename()
		{
			return null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000039A7 File Offset: 0x00001BA7
		public virtual void setFilename(string name)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000039A9 File Offset: 0x00001BA9
		public virtual string getText()
		{
			return "<no text>";
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x000039B0 File Offset: 0x00001BB0
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000039B8 File Offset: 0x00001BB8
		public int Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000039C1 File Offset: 0x00001BC1
		public virtual void setType(int newType)
		{
			this.Type = newType;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000039CA File Offset: 0x00001BCA
		public virtual void setColumn(int c)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000039CC File Offset: 0x00001BCC
		public virtual void setLine(int l)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000039CE File Offset: 0x00001BCE
		public virtual void setText(string t)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000039D0 File Offset: 0x00001BD0
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"[\"",
				this.getText(),
				"\",<",
				this.type_,
				">]"
			});
		}

		// Token: 0x04000056 RID: 86
		public const int MIN_USER_TYPE = 4;

		// Token: 0x04000057 RID: 87
		public const int NULL_TREE_LOOKAHEAD = 3;

		// Token: 0x04000058 RID: 88
		public const int INVALID_TYPE = 0;

		// Token: 0x04000059 RID: 89
		public const int EOF_TYPE = 1;

		// Token: 0x0400005A RID: 90
		public static readonly int SKIP = -1;

		// Token: 0x0400005B RID: 91
		protected int type_;

		// Token: 0x0400005C RID: 92
		public static Token badToken = new Token(0, "<no text>");
	}
}
