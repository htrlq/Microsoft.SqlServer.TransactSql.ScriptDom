using System;
using antlr.collections.impl;

namespace antlr
{
	// Token: 0x02000028 RID: 40
	internal class TokenStreamHiddenTokenFilter : TokenStreamBasicFilter, TokenStream
	{
		// Token: 0x06000143 RID: 323 RVA: 0x00004FA1 File Offset: 0x000031A1
		public TokenStreamHiddenTokenFilter(TokenStream input) : base(input)
		{
			this.hideMask = new BitSet();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00004FB5 File Offset: 0x000031B5
		protected internal virtual void consume()
		{
			this.nextMonitoredToken = (IHiddenStreamToken)this.input.nextToken();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00004FD0 File Offset: 0x000031D0
		private void consumeFirst()
		{
			this.consume();
			IHiddenStreamToken hiddenStreamToken = null;
			while (this.hideMask.member(this.LA(1).Type) || this.discardMask.member(this.LA(1).Type))
			{
				if (this.hideMask.member(this.LA(1).Type))
				{
					if (hiddenStreamToken == null)
					{
						hiddenStreamToken = this.LA(1);
					}
					else
					{
						hiddenStreamToken.setHiddenAfter(this.LA(1));
						this.LA(1).setHiddenBefore(hiddenStreamToken);
						hiddenStreamToken = this.LA(1);
					}
					this.lastHiddenToken = hiddenStreamToken;
					if (this.firstHidden == null)
					{
						this.firstHidden = hiddenStreamToken;
					}
				}
				this.consume();
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00005080 File Offset: 0x00003280
		public virtual BitSet getDiscardMask()
		{
			return this.discardMask;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00005088 File Offset: 0x00003288
		public virtual IHiddenStreamToken getHiddenAfter(IHiddenStreamToken t)
		{
			return t.getHiddenAfter();
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00005090 File Offset: 0x00003290
		public virtual IHiddenStreamToken getHiddenBefore(IHiddenStreamToken t)
		{
			return t.getHiddenBefore();
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00005098 File Offset: 0x00003298
		public virtual BitSet getHideMask()
		{
			return this.hideMask;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000050A0 File Offset: 0x000032A0
		public virtual IHiddenStreamToken getInitialHiddenToken()
		{
			return this.firstHidden;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000050A8 File Offset: 0x000032A8
		public virtual void hide(int m)
		{
			this.hideMask.add(m);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000050B6 File Offset: 0x000032B6
		public virtual void hide(BitSet mask)
		{
			this.hideMask = mask;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000050BF File Offset: 0x000032BF
		protected internal virtual IHiddenStreamToken LA(int i)
		{
			return this.nextMonitoredToken;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000050C8 File Offset: 0x000032C8
		public override IToken nextToken()
		{
			if (this.LA(1) == null)
			{
				this.consumeFirst();
			}
			IHiddenStreamToken hiddenStreamToken = this.LA(1);
			hiddenStreamToken.setHiddenBefore(this.lastHiddenToken);
			this.lastHiddenToken = null;
			this.consume();
			IHiddenStreamToken hiddenStreamToken2 = hiddenStreamToken;
			while (this.hideMask.member(this.LA(1).Type) || this.discardMask.member(this.LA(1).Type))
			{
				if (this.hideMask.member(this.LA(1).Type))
				{
					hiddenStreamToken2.setHiddenAfter(this.LA(1));
					if (hiddenStreamToken2 != hiddenStreamToken)
					{
						this.LA(1).setHiddenBefore(hiddenStreamToken2);
					}
					hiddenStreamToken2 = (this.lastHiddenToken = this.LA(1));
				}
				this.consume();
			}
			return hiddenStreamToken;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000518A File Offset: 0x0000338A
		public virtual void resetState()
		{
			this.firstHidden = null;
			this.lastHiddenToken = null;
			this.nextMonitoredToken = null;
		}

		// Token: 0x040000AF RID: 175
		protected internal BitSet hideMask;

		// Token: 0x040000B0 RID: 176
		private IHiddenStreamToken nextMonitoredToken;

		// Token: 0x040000B1 RID: 177
		protected internal IHiddenStreamToken lastHiddenToken;

		// Token: 0x040000B2 RID: 178
		protected internal IHiddenStreamToken firstHidden;
	}
}
