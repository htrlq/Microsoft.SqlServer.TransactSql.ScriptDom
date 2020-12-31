using System;
using antlr.collections.impl;

namespace antlr
{
	// Token: 0x02000026 RID: 38
	internal class TokenStreamBasicFilter : TokenStream
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00004F16 File Offset: 0x00003116
		public TokenStreamBasicFilter(TokenStream input)
		{
			this.input = input;
			this.discardMask = new BitSet();
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00004F30 File Offset: 0x00003130
		public virtual void discard(int ttype)
		{
			this.discardMask.add(ttype);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00004F3E File Offset: 0x0000313E
		public virtual void discard(BitSet mask)
		{
			this.discardMask = mask;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00004F48 File Offset: 0x00003148
		public virtual IToken nextToken()
		{
			IToken token = this.input.nextToken();
			while (token != null && this.discardMask.member(token.Type))
			{
				token = this.input.nextToken();
			}
			return token;
		}

		// Token: 0x040000AD RID: 173
		protected internal BitSet discardMask;

		// Token: 0x040000AE RID: 174
		protected internal TokenStream input;
	}
}
