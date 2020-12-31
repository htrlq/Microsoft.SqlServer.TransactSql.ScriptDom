using System;
using System.Collections;

namespace antlr
{
	// Token: 0x02000031 RID: 49
	internal class TokenStreamSelector : TokenStream
	{
		// Token: 0x0600018C RID: 396 RVA: 0x00005820 File Offset: 0x00003A20
		public TokenStreamSelector()
		{
			this.inputStreamNames = new Hashtable();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000583E File Offset: 0x00003A3E
		public virtual void addInputStream(TokenStream stream, string key)
		{
			this.inputStreamNames[key] = stream;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000584D File Offset: 0x00003A4D
		public virtual TokenStream getCurrentStream()
		{
			return this.input;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00005858 File Offset: 0x00003A58
		public virtual TokenStream getStream(string sname)
		{
			TokenStream tokenStream = (TokenStream)this.inputStreamNames[sname];
			if (tokenStream == null)
			{
				throw new ArgumentException("TokenStream " + sname + " not found");
			}
			return tokenStream;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00005894 File Offset: 0x00003A94
		public virtual IToken nextToken()
		{
			IToken result;

            IL_00:
			try
			{
                result = this.input.nextToken();
			}
			catch (TokenStreamRetryException)
			{
				goto IL_00;
			}
			return result;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000058C4 File Offset: 0x00003AC4
		public virtual TokenStream pop()
		{
			TokenStream tokenStream = (TokenStream)this.streamStack.Pop();
			this.select(tokenStream);
			return tokenStream;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000058EA File Offset: 0x00003AEA
		public virtual void push(TokenStream stream)
		{
			this.streamStack.Push(this.input);
			this.select(stream);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00005904 File Offset: 0x00003B04
		public virtual void push(string sname)
		{
			this.streamStack.Push(this.input);
			this.select(sname);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000591E File Offset: 0x00003B1E
		public virtual void retry()
		{
			throw new TokenStreamRetryException();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00005925 File Offset: 0x00003B25
		public virtual void select(TokenStream stream)
		{
			this.input = stream;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000592E File Offset: 0x00003B2E
		public virtual void select(string sname)
		{
			this.input = this.getStream(sname);
		}

		// Token: 0x040000C1 RID: 193
		protected internal Hashtable inputStreamNames;

		// Token: 0x040000C2 RID: 194
		protected internal TokenStream input;

		// Token: 0x040000C3 RID: 195
		protected internal Stack streamStack = new Stack();
	}
}
