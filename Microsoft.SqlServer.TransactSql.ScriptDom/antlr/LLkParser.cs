using System;

namespace antlr
{
	// Token: 0x02000019 RID: 25
	internal class LLkParser : Parser
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x000040E1 File Offset: 0x000022E1
		public LLkParser(int k_)
		{
			this.k = k_;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000040F0 File Offset: 0x000022F0
		public LLkParser(ParserSharedInputState state, int k_)
		{
			this.k = k_;
			this.inputState = state;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00004106 File Offset: 0x00002306
		public LLkParser(TokenBuffer tokenBuf, int k_)
		{
			this.k = k_;
			this.setTokenBuffer(tokenBuf);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000411C File Offset: 0x0000231C
		public LLkParser(TokenStream lexer, int k_)
		{
			this.k = k_;
			TokenBuffer tokenBuffer = new TokenBuffer(lexer);
			this.setTokenBuffer(tokenBuffer);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004144 File Offset: 0x00002344
		public override void consume()
		{
			this.inputState.input.consume();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00004156 File Offset: 0x00002356
		public override int LA(int i)
		{
			return this.inputState.input.LA(i);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004169 File Offset: 0x00002369
		public override IToken LT(int i)
		{
			return this.inputState.input.LT(i);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000417C File Offset: 0x0000237C
		private void trace(string ee, string rname)
		{
			this.traceIndent();
			Console.Out.Write(ee + rname + ((this.inputState.guessing > 0) ? "; [guessing]" : "; "));
			for (int i = 1; i <= this.k; i++)
			{
				if (i != 1)
				{
					Console.Out.Write(", ");
				}
				if (this.LT(i) != null)
				{
					Console.Out.Write(string.Concat(new object[]
					{
						"LA(",
						i,
						")==",
						this.LT(i).getText()
					}));
				}
				else
				{
					Console.Out.Write("LA(" + i + ")==ull");
				}
			}
			Console.Out.WriteLine("");
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000425C File Offset: 0x0000245C
		public override void traceIn(string rname)
		{
			this.traceDepth++;
			this.trace("> ", rname);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004278 File Offset: 0x00002478
		public override void traceOut(string rname)
		{
			this.trace("< ", rname);
			this.traceDepth--;
		}

		// Token: 0x04000080 RID: 128
		internal int k;
	}
}
