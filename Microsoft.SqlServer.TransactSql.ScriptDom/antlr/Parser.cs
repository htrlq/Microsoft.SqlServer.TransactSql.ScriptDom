using System;
using antlr.collections.impl;

namespace antlr
{
	// Token: 0x02000018 RID: 24
	internal abstract class Parser
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x00003CEB File Offset: 0x00001EEB
		public Parser()
		{
			this.inputState = new ParserSharedInputState();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00003CFE File Offset: 0x00001EFE
		public Parser(ParserSharedInputState state)
		{
			this.inputState = state;
		}

		// Token: 0x060000DB RID: 219
		public abstract void consume();

		// Token: 0x060000DC RID: 220 RVA: 0x00003D0D File Offset: 0x00001F0D
		public virtual void consumeUntil(int tokenType)
		{
			while (this.LA(1) != 1 && this.LA(1) != tokenType)
			{
				this.consume();
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003D2B File Offset: 0x00001F2B
		public virtual void consumeUntil(BitSet bset)
		{
			while (this.LA(1) != 1 && !bset.member(this.LA(1)))
			{
				this.consume();
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00003D4E File Offset: 0x00001F4E
		protected internal virtual void defaultDebuggingSetup(TokenStream lexer, TokenBuffer tokBuf)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003D50 File Offset: 0x00001F50
		public virtual string getFilename()
		{
			return this.inputState.filename;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003D5D File Offset: 0x00001F5D
		public virtual ParserSharedInputState getInputState()
		{
			return this.inputState;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003D65 File Offset: 0x00001F65
		public virtual void setInputState(ParserSharedInputState state)
		{
			this.inputState = state;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00003D6E File Offset: 0x00001F6E
		public virtual void resetState()
		{
			this.traceDepth = 0;
			this.inputState.reset();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00003D82 File Offset: 0x00001F82
		public virtual string getTokenName(int num)
		{
			return this.tokenNames[num];
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00003D8C File Offset: 0x00001F8C
		public virtual string[] getTokenNames()
		{
			return this.tokenNames;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00003D94 File Offset: 0x00001F94
		public virtual bool isDebugMode()
		{
			return false;
		}

		// Token: 0x060000E6 RID: 230
		public abstract int LA(int i);

		// Token: 0x060000E7 RID: 231
		public abstract IToken LT(int i);

		// Token: 0x060000E8 RID: 232 RVA: 0x00003D97 File Offset: 0x00001F97
		public virtual int mark()
		{
			return this.inputState.input.mark();
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00003DA9 File Offset: 0x00001FA9
		public virtual void match(int t)
		{
			if (this.LA(1) != t)
			{
				throw new MismatchedTokenException(this.tokenNames, this.LT(1), t, false, this.getFilename());
			}
			this.consume();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003DD6 File Offset: 0x00001FD6
		public virtual void match(BitSet b)
		{
			if (!b.member(this.LA(1)))
			{
				throw new MismatchedTokenException(this.tokenNames, this.LT(1), b, false, this.getFilename());
			}
			this.consume();
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003E08 File Offset: 0x00002008
		public virtual void matchNot(int t)
		{
			if (this.LA(1) == t)
			{
				throw new MismatchedTokenException(this.tokenNames, this.LT(1), t, true, this.getFilename());
			}
			this.consume();
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003E35 File Offset: 0x00002035
		public virtual void reportError(RecognitionException ex)
		{
			Console.Error.WriteLine(ex);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003E42 File Offset: 0x00002042
		public virtual void reportError(string s)
		{
			if (this.getFilename() == null)
			{
				Console.Error.WriteLine("error: " + s);
				return;
			}
			Console.Error.WriteLine(this.getFilename() + ": error: " + s);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003E7D File Offset: 0x0000207D
		public virtual void reportWarning(string s)
		{
			if (this.getFilename() == null)
			{
				Console.Error.WriteLine("warning: " + s);
				return;
			}
			Console.Error.WriteLine(this.getFilename() + ": warning: " + s);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003EB8 File Offset: 0x000020B8
		public virtual void recover(RecognitionException ex, BitSet tokenSet)
		{
			this.consume();
			this.consumeUntil(tokenSet);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003EC7 File Offset: 0x000020C7
		public virtual void rewind(int pos)
		{
			this.inputState.input.rewind(pos);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003EDA File Offset: 0x000020DA
		public virtual void setDebugMode(bool debugMode)
		{
			if (!this.ignoreInvalidDebugCalls)
			{
				throw new ANTLRException("setDebugMode() only valid if parser built for debugging");
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00003EEF File Offset: 0x000020EF
		public virtual void setFilename(string f)
		{
			this.inputState.filename = f;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00003EFD File Offset: 0x000020FD
		public virtual void setIgnoreInvalidDebugCalls(bool Value)
		{
			this.ignoreInvalidDebugCalls = Value;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00003F06 File Offset: 0x00002106
		public virtual void setTokenBuffer(TokenBuffer t)
		{
			this.inputState.input = t;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00003F14 File Offset: 0x00002114
		public virtual void traceIndent()
		{
			for (int i = 0; i < this.traceDepth; i++)
			{
				Console.Out.Write(" ");
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003F44 File Offset: 0x00002144
		public virtual void traceIn(string rname)
		{
			this.traceDepth++;
			this.traceIndent();
			Console.Out.WriteLine(string.Concat(new string[]
			{
				"> ",
				rname,
				"; LA(1)==",
				this.LT(1).getText(),
				(this.inputState.guessing > 0) ? " [guessing]" : ""
			}));
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00003FBC File Offset: 0x000021BC
		public virtual void traceOut(string rname)
		{
			this.traceIndent();
			Console.Out.WriteLine(string.Concat(new string[]
			{
				"< ",
				rname,
				"; LA(1)==",
				this.LT(1).getText(),
				(this.inputState.guessing > 0) ? " [guessing]" : ""
			}));
			this.traceDepth--;
		}

		// Token: 0x0400006C RID: 108
		internal static readonly object EnterRuleEventKey = new object();

		// Token: 0x0400006D RID: 109
		internal static readonly object ExitRuleEventKey = new object();

		// Token: 0x0400006E RID: 110
		internal static readonly object DoneEventKey = new object();

		// Token: 0x0400006F RID: 111
		internal static readonly object ReportErrorEventKey = new object();

		// Token: 0x04000070 RID: 112
		internal static readonly object ReportWarningEventKey = new object();

		// Token: 0x04000071 RID: 113
		internal static readonly object NewLineEventKey = new object();

		// Token: 0x04000072 RID: 114
		internal static readonly object MatchEventKey = new object();

		// Token: 0x04000073 RID: 115
		internal static readonly object MatchNotEventKey = new object();

		// Token: 0x04000074 RID: 116
		internal static readonly object MisMatchEventKey = new object();

		// Token: 0x04000075 RID: 117
		internal static readonly object MisMatchNotEventKey = new object();

		// Token: 0x04000076 RID: 118
		internal static readonly object ConsumeEventKey = new object();

		// Token: 0x04000077 RID: 119
		internal static readonly object LAEventKey = new object();

		// Token: 0x04000078 RID: 120
		internal static readonly object SemPredEvaluatedEventKey = new object();

		// Token: 0x04000079 RID: 121
		internal static readonly object SynPredStartedEventKey = new object();

		// Token: 0x0400007A RID: 122
		internal static readonly object SynPredFailedEventKey = new object();

		// Token: 0x0400007B RID: 123
		internal static readonly object SynPredSucceededEventKey = new object();

		// Token: 0x0400007C RID: 124
		protected internal ParserSharedInputState inputState;

		// Token: 0x0400007D RID: 125
		protected internal string[] tokenNames;

		// Token: 0x0400007E RID: 126
		private bool ignoreInvalidDebugCalls;

		// Token: 0x0400007F RID: 127
		protected internal int traceDepth;
	}
}
