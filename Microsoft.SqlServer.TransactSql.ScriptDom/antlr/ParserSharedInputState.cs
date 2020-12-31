using System;

namespace antlr
{
	// Token: 0x02000021 RID: 33
	internal class ParserSharedInputState
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00004AF2 File Offset: 0x00002CF2
		public virtual void reset()
		{
			this.guessing = 0;
			this.filename = null;
			this.input.reset();
		}

		// Token: 0x040000A1 RID: 161
		protected internal TokenBuffer input;

		// Token: 0x040000A2 RID: 162
		public int guessing;

		// Token: 0x040000A3 RID: 163
		protected internal string filename;
	}
}
