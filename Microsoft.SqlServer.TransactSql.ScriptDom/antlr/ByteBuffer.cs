using System;
using System.IO;

namespace antlr
{
	// Token: 0x02000007 RID: 7
	internal class ByteBuffer : InputBuffer
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00002BB1 File Offset: 0x00000DB1
		public ByteBuffer(Stream input_)
		{
			this.input = input_;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002BD0 File Offset: 0x00000DD0
		public override void fill(int amount)
		{
			this.syncConsume();
			int i = amount + this.markerOffset - this.queue.Count;
			while (i > 0)
			{
				int num = this.input.Read(this.buf, 0, 16);
				for (int j = 0; j < num; j++)
				{
					this.queue.Add((char)this.buf[j]);
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

		// Token: 0x0400002B RID: 43
		private const int BUF_SIZE = 16;

		// Token: 0x0400002C RID: 44
		[NonSerialized]
		internal Stream input;

		// Token: 0x0400002D RID: 45
		private byte[] buf = new byte[16];
	}
}
