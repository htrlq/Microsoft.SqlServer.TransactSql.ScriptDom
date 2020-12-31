using System;
using System.IO;

namespace antlr
{
	// Token: 0x02000008 RID: 8
	internal class CharBuffer : InputBuffer
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002C62 File Offset: 0x00000E62
		public CharBuffer(TextReader input_)
		{
			this.input = input_;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002C80 File Offset: 0x00000E80
		public override void fill(int amount)
		{
			this.syncConsume();
			int i = amount + this.markerOffset - this.queue.Count;
			while (i > 0)
			{
				int num = this.input.Read(this.buf, 0, 16);
				for (int j = 0; j < num; j++)
				{
					this.queue.Add(this.buf[j]);
				}
				i -= num;
				if (num < 16)
				{
					while (i-- > 0)
					{
						this.queue.Add(CharScanner.EOF_CHAR);
					}
					return;
				}
			}
		}

		// Token: 0x0400002E RID: 46
		private const int BUF_SIZE = 16;

		// Token: 0x0400002F RID: 47
		[NonSerialized]
		internal TextReader input;

		// Token: 0x04000030 RID: 48
		private char[] buf = new char[16];
	}
}
