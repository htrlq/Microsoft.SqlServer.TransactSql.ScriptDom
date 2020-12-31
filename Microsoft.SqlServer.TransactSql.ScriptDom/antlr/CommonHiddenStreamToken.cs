using System;

namespace antlr
{
	// Token: 0x02000013 RID: 19
	internal class CommonHiddenStreamToken : CommonToken, IHiddenStreamToken, IToken
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00003B33 File Offset: 0x00001D33
		public CommonHiddenStreamToken()
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003B3B File Offset: 0x00001D3B
		public CommonHiddenStreamToken(int t, string txt) : base(t, txt)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003B45 File Offset: 0x00001D45
		public CommonHiddenStreamToken(string s) : base(s)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003B4E File Offset: 0x00001D4E
		public virtual IHiddenStreamToken getHiddenAfter()
		{
			return this.hiddenAfter;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00003B56 File Offset: 0x00001D56
		public virtual IHiddenStreamToken getHiddenBefore()
		{
			return this.hiddenBefore;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003B5E File Offset: 0x00001D5E
		public virtual void setHiddenAfter(IHiddenStreamToken t)
		{
			this.hiddenAfter = t;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003B67 File Offset: 0x00001D67
		public virtual void setHiddenBefore(IHiddenStreamToken t)
		{
			this.hiddenBefore = t;
		}

		// Token: 0x04000061 RID: 97
		public new static readonly CommonHiddenStreamToken.CommonHiddenStreamTokenCreator Creator = new CommonHiddenStreamToken.CommonHiddenStreamTokenCreator();

		// Token: 0x04000062 RID: 98
		protected internal IHiddenStreamToken hiddenBefore;

		// Token: 0x04000063 RID: 99
		protected internal IHiddenStreamToken hiddenAfter;

		// Token: 0x02000014 RID: 20
		internal class CommonHiddenStreamTokenCreator : TokenCreator
		{
			// Token: 0x17000007 RID: 7
			// (get) Token: 0x060000C8 RID: 200 RVA: 0x00003B84 File Offset: 0x00001D84
			public override string TokenTypeName
			{
				get
				{
					return typeof(CommonHiddenStreamToken).FullName;
				}
			}

			// Token: 0x060000C9 RID: 201 RVA: 0x00003B95 File Offset: 0x00001D95
			public override IToken Create()
			{
				return new CommonHiddenStreamToken();
			}
		}
	}
}
