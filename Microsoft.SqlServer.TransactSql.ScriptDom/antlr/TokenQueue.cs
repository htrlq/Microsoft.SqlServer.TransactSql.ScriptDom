using System;

namespace antlr
{
	// Token: 0x02000025 RID: 37
	internal class TokenQueue
	{
		// Token: 0x06000135 RID: 309 RVA: 0x00004DB4 File Offset: 0x00002FB4
		public TokenQueue(int minSize)
		{
			if (minSize < 0)
			{
				this.init(16);
				return;
			}
			if (minSize >= 1073741823)
			{
				this.init(int.MaxValue);
				return;
			}
			int i;
			for (i = 2; i < minSize; i *= 2)
			{
			}
			this.init(i);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00004DFC File Offset: 0x00002FFC
		public void append(IToken tok)
		{
			if (this.nbrEntries == this.buffer.Length)
			{
				this.expand();
			}
			this.buffer[this.offset + this.nbrEntries & this.sizeLessOne] = tok;
			this.nbrEntries++;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004E49 File Offset: 0x00003049
		public IToken elementAt(int idx)
		{
			return this.buffer[this.offset + idx & this.sizeLessOne];
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004E64 File Offset: 0x00003064
		private void expand()
		{
			IToken[] array = new IToken[this.buffer.Length * 2];
			for (int i = 0; i < this.buffer.Length; i++)
			{
				array[i] = this.elementAt(i);
			}
			this.buffer = array;
			this.sizeLessOne = this.buffer.Length - 1;
			this.offset = 0;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00004EBC File Offset: 0x000030BC
		private void init(int size)
		{
			this.buffer = new IToken[size];
			this.sizeLessOne = size - 1;
			this.offset = 0;
			this.nbrEntries = 0;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00004EE1 File Offset: 0x000030E1
		public void reset()
		{
			this.offset = 0;
			this.nbrEntries = 0;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00004EF1 File Offset: 0x000030F1
		public void removeFirst()
		{
			this.offset = (this.offset + 1 & this.sizeLessOne);
			this.nbrEntries--;
		}

		// Token: 0x040000A9 RID: 169
		private IToken[] buffer;

		// Token: 0x040000AA RID: 170
		private int sizeLessOne;

		// Token: 0x040000AB RID: 171
		private int offset;

		// Token: 0x040000AC RID: 172
		protected internal int nbrEntries;
	}
}
