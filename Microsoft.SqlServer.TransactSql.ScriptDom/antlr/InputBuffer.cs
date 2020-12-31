using System;
using System.Collections;
using System.Text;

namespace antlr
{
	// Token: 0x02000006 RID: 6
	internal abstract class InputBuffer
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002A05 File Offset: 0x00000C05
		public InputBuffer()
		{
			this.queue = new ArrayList();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002A18 File Offset: 0x00000C18
		public virtual void commit()
		{
			this.nMarkers--;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002A28 File Offset: 0x00000C28
		public virtual char consume()
		{
			this.numToConsume++;
			return this.LA(1);
		}

		// Token: 0x06000038 RID: 56
		public abstract void fill(int amount);

		// Token: 0x06000039 RID: 57 RVA: 0x00002A40 File Offset: 0x00000C40
		public virtual string getLAChars()
		{
			StringBuilder stringBuilder = new StringBuilder();
			char[] array = new char[this.queue.Count - this.markerOffset];
			this.queue.CopyTo(array, this.markerOffset);
			stringBuilder.Append(array);
			return stringBuilder.ToString();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002A8C File Offset: 0x00000C8C
		public virtual string getMarkedChars()
		{
			StringBuilder stringBuilder = new StringBuilder();
			char[] array = new char[this.queue.Count - this.markerOffset];
			this.queue.CopyTo(array, this.markerOffset);
			stringBuilder.Append(array);
			return stringBuilder.ToString();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002AD7 File Offset: 0x00000CD7
		public virtual bool isMarked()
		{
			return this.nMarkers != 0;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002AE5 File Offset: 0x00000CE5
		public virtual char LA(int i)
		{
			this.fill(i);
			return (char)this.queue[this.markerOffset + i - 1];
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002B08 File Offset: 0x00000D08
		public virtual int mark()
		{
			this.syncConsume();
			this.nMarkers++;
			return this.markerOffset;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002B24 File Offset: 0x00000D24
		public virtual void rewind(int mark)
		{
			this.syncConsume();
			this.markerOffset = mark;
			this.nMarkers--;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002B41 File Offset: 0x00000D41
		public virtual void reset()
		{
			this.nMarkers = 0;
			this.markerOffset = 0;
			this.numToConsume = 0;
			this.queue.Clear();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002B64 File Offset: 0x00000D64
		protected internal virtual void syncConsume()
		{
			if (this.numToConsume > 0)
			{
				if (this.nMarkers > 0)
				{
					this.markerOffset += this.numToConsume;
				}
				else
				{
					this.queue.RemoveRange(0, this.numToConsume);
				}
				this.numToConsume = 0;
			}
		}

		// Token: 0x04000027 RID: 39
		protected internal int nMarkers;

		// Token: 0x04000028 RID: 40
		protected internal int markerOffset;

		// Token: 0x04000029 RID: 41
		protected internal int numToConsume;

		// Token: 0x0400002A RID: 42
		protected ArrayList queue;
	}
}
