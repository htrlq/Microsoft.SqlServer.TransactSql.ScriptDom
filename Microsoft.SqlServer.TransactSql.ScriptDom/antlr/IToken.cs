using System;

namespace antlr
{
	// Token: 0x0200000E RID: 14
	internal interface IToken
	{
		// Token: 0x06000093 RID: 147
		int getColumn();

		// Token: 0x06000094 RID: 148
		void setColumn(int c);

		// Token: 0x06000095 RID: 149
		int getLine();

		// Token: 0x06000096 RID: 150
		void setLine(int l);

		// Token: 0x06000097 RID: 151
		string getFilename();

		// Token: 0x06000098 RID: 152
		void setFilename(string name);

		// Token: 0x06000099 RID: 153
		string getText();

		// Token: 0x0600009A RID: 154
		void setText(string t);

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600009B RID: 155
		// (set) Token: 0x0600009C RID: 156
		int Type { get; set; }
	}
}
