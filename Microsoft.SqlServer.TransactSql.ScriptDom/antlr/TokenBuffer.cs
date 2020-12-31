using System;

namespace antlr
{
	// Token: 0x02000024 RID: 36
	internal class TokenBuffer
	{
		// Token: 0x0600012B RID: 299 RVA: 0x00004C6F File Offset: 0x00002E6F
		public TokenBuffer(TokenStream input_)
		{
			this.input = input_;
			this.queue = new TokenQueue(1);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00004C8A File Offset: 0x00002E8A
		public virtual void reset()
		{
			this.nMarkers = 0;
			this.markerOffset = 0;
			this.numToConsume = 0;
			this.queue.reset();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00004CAC File Offset: 0x00002EAC
		public virtual void consume()
		{
			this.numToConsume++;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004CBC File Offset: 0x00002EBC
		protected virtual void fill(int amount)
		{
			this.syncConsume();
			while (this.queue.nbrEntries < amount + this.markerOffset)
			{
				this.queue.append(this.input.nextToken());
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00004CF1 File Offset: 0x00002EF1
		public virtual TokenStream getInput()
		{
			return this.input;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004CF9 File Offset: 0x00002EF9
		public virtual int LA(int i)
		{
			this.fill(i);
			return this.queue.elementAt(this.markerOffset + i - 1).Type;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004D1C File Offset: 0x00002F1C
		public virtual IToken LT(int i)
		{
			this.fill(i);
			return this.queue.elementAt(this.markerOffset + i - 1);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004D3A File Offset: 0x00002F3A
		public virtual int mark()
		{
			this.syncConsume();
			this.nMarkers++;
			return this.markerOffset;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004D56 File Offset: 0x00002F56
		public virtual void rewind(int mark)
		{
			this.syncConsume();
			this.markerOffset = mark;
			this.nMarkers--;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004D73 File Offset: 0x00002F73
		protected virtual void syncConsume()
		{
			while (this.numToConsume > 0)
			{
				if (this.nMarkers > 0)
				{
					this.markerOffset++;
				}
				else
				{
					this.queue.removeFirst();
				}
				this.numToConsume--;
			}
		}

		// Token: 0x040000A4 RID: 164
		protected internal TokenStream input;

		// Token: 0x040000A5 RID: 165
		protected internal int nMarkers;

		// Token: 0x040000A6 RID: 166
		protected internal int markerOffset;

		// Token: 0x040000A7 RID: 167
		protected internal int numToConsume;

		// Token: 0x040000A8 RID: 168
		internal TokenQueue queue;
	}
}
