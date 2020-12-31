using System;
using System.IO;

namespace antlr
{
	// Token: 0x02000017 RID: 23
	internal class LexerSharedInputState
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x00003C44 File Offset: 0x00001E44
		public LexerSharedInputState(InputBuffer inbuf)
		{
			this.initialize();
			this.input = inbuf;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003C59 File Offset: 0x00001E59
		public LexerSharedInputState(Stream inStream) : this(new ByteBuffer(inStream))
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003C67 File Offset: 0x00001E67
		public LexerSharedInputState(TextReader inReader) : this(new CharBuffer(inReader))
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003C75 File Offset: 0x00001E75
		private void initialize()
		{
			this.column = 1;
			this.line = 1;
			this.tokenStartColumn = 1;
			this.tokenStartLine = 1;
			this.guessing = 0;
			this.filename = null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003CA1 File Offset: 0x00001EA1
		public virtual void reset()
		{
			this.initialize();
			this.input.reset();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003CB4 File Offset: 0x00001EB4
		public virtual void resetInput(InputBuffer ib)
		{
			this.reset();
			this.input = ib;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00003CC3 File Offset: 0x00001EC3
		public virtual void resetInput(Stream s)
		{
			this.reset();
			this.input = new ByteBuffer(s);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00003CD7 File Offset: 0x00001ED7
		public virtual void resetInput(TextReader tr)
		{
			this.reset();
			this.input = new CharBuffer(tr);
		}

		// Token: 0x04000065 RID: 101
		protected internal int column;

		// Token: 0x04000066 RID: 102
		protected internal int line;

		// Token: 0x04000067 RID: 103
		protected internal int tokenStartColumn;

		// Token: 0x04000068 RID: 104
		protected internal int tokenStartLine;

		// Token: 0x04000069 RID: 105
		protected internal InputBuffer input;

		// Token: 0x0400006A RID: 106
		protected internal string filename;

		// Token: 0x0400006B RID: 107
		public int guessing;
	}
}
