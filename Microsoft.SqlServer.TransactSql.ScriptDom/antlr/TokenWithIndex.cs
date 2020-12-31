using System;

namespace antlr
{
	// Token: 0x02000032 RID: 50
	internal class TokenWithIndex : CommonToken
	{
		// Token: 0x06000197 RID: 407 RVA: 0x0000593D File Offset: 0x00003B3D
		public TokenWithIndex()
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00005945 File Offset: 0x00003B45
		public TokenWithIndex(int i, string t) : base(i, t)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000594F File Offset: 0x00003B4F
		public void setIndex(int i)
		{
			this.index = i;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00005958 File Offset: 0x00003B58
		public int getIndex()
		{
			return this.index;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00005960 File Offset: 0x00003B60
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"[",
				this.index,
				":\"",
				this.getText(),
				"\",<",
				base.Type,
				">,line=",
				this.line,
				",col=",
				this.col,
				"]\n"
			});
		}

		// Token: 0x040000C4 RID: 196
		private int index;
	}
}
