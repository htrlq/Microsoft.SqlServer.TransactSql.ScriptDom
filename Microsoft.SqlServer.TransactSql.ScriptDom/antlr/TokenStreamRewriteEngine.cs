using System;
using System.Collections;
using System.Text;
using antlr.collections.impl;

namespace antlr
{
	// Token: 0x0200002B RID: 43
	internal class TokenStreamRewriteEngine : TokenStream
	{
		// Token: 0x06000155 RID: 341 RVA: 0x000051DF File Offset: 0x000033DF
		public TokenStreamRewriteEngine(TokenStream upstream) : this(upstream, 1000)
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000051F0 File Offset: 0x000033F0
		public TokenStreamRewriteEngine(TokenStream upstream, int initialSize)
		{
			this.stream = upstream;
			this.tokens = new ArrayList(initialSize);
			this.programs = new Hashtable();
			this.programs["default"] = new ArrayList(100);
			this.lastRewriteTokenIndexes = new Hashtable();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00005250 File Offset: 0x00003450
		public IToken nextToken()
		{
			TokenWithIndex tokenWithIndex;
			do
			{
				tokenWithIndex = (TokenWithIndex)this.stream.nextToken();
				if (tokenWithIndex != null)
				{
					tokenWithIndex.setIndex(this._index);
					if (tokenWithIndex.Type != 1)
					{
						this.tokens.Add(tokenWithIndex);
					}
					this._index++;
				}
			}
			while (tokenWithIndex != null && this.discardMask.member(tokenWithIndex.Type));
			return tokenWithIndex;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000052B8 File Offset: 0x000034B8
		public void rollback(int instructionIndex)
		{
			this.rollback("default", instructionIndex);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000052C8 File Offset: 0x000034C8
		public void rollback(string programName, int instructionIndex)
		{
			ArrayList arrayList = (ArrayList)this.programs[programName];
			if (arrayList != null)
			{
				this.programs[programName] = arrayList.GetRange(0, instructionIndex);
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000052FE File Offset: 0x000034FE
		public void deleteProgram()
		{
			this.deleteProgram("default");
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000530B File Offset: 0x0000350B
		public void deleteProgram(string programName)
		{
			this.rollback(programName, 0);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00005315 File Offset: 0x00003515
		protected void addToSortedRewriteList(TokenStreamRewriteEngine.RewriteOperation op)
		{
			this.addToSortedRewriteList("default", op);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00005324 File Offset: 0x00003524
		protected void addToSortedRewriteList(string programName, TokenStreamRewriteEngine.RewriteOperation op)
		{
			ArrayList arrayList = (ArrayList)this.getProgram(programName);
			if (op.index >= this.getLastRewriteTokenIndex(programName))
			{
				arrayList.Add(op);
				this.setLastRewriteTokenIndex(programName, op.index);
				return;
			}
			int num = arrayList.BinarySearch(op, TokenStreamRewriteEngine.RewriteOperationComparer.Default);
			if (num < 0)
			{
				arrayList.Insert(-num - 1, op);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000537F File Offset: 0x0000357F
		public void insertAfter(IToken t, string text)
		{
			this.insertAfter("default", t, text);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000538E File Offset: 0x0000358E
		public void insertAfter(int index, string text)
		{
			this.insertAfter("default", index, text);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000539D File Offset: 0x0000359D
		public void insertAfter(string programName, IToken t, string text)
		{
			this.insertAfter(programName, ((TokenWithIndex)t).getIndex(), text);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000053B2 File Offset: 0x000035B2
		public void insertAfter(string programName, int index, string text)
		{
			this.insertBefore(programName, index + 1, text);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000053BF File Offset: 0x000035BF
		public void insertBefore(IToken t, string text)
		{
			this.insertBefore("default", t, text);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000053CE File Offset: 0x000035CE
		public void insertBefore(int index, string text)
		{
			this.insertBefore("default", index, text);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000053DD File Offset: 0x000035DD
		public void insertBefore(string programName, IToken t, string text)
		{
			this.insertBefore(programName, ((TokenWithIndex)t).getIndex(), text);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000053F2 File Offset: 0x000035F2
		public void insertBefore(string programName, int index, string text)
		{
			this.addToSortedRewriteList(programName, new TokenStreamRewriteEngine.InsertBeforeOp(index, text));
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00005402 File Offset: 0x00003602
		public void replace(int index, string text)
		{
			this.replace("default", index, index, text);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00005412 File Offset: 0x00003612
		public void replace(int from, int to, string text)
		{
			this.replace("default", from, to, text);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00005422 File Offset: 0x00003622
		public void replace(IToken indexT, string text)
		{
			this.replace("default", indexT, indexT, text);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00005432 File Offset: 0x00003632
		public void replace(IToken from, IToken to, string text)
		{
			this.replace("default", from, to, text);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00005442 File Offset: 0x00003642
		public void replace(string programName, int from, int to, string text)
		{
			this.addToSortedRewriteList(programName, new TokenStreamRewriteEngine.ReplaceOp(from, to, text));
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00005454 File Offset: 0x00003654
		public void replace(string programName, IToken from, IToken to, string text)
		{
			this.replace(programName, ((TokenWithIndex)from).getIndex(), ((TokenWithIndex)to).getIndex(), text);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00005475 File Offset: 0x00003675
		public void delete(int index)
		{
			this.delete("default", index, index);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00005484 File Offset: 0x00003684
		public void delete(int from, int to)
		{
			this.delete("default", from, to);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00005493 File Offset: 0x00003693
		public void delete(IToken indexT)
		{
			this.delete("default", indexT, indexT);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000054A2 File Offset: 0x000036A2
		public void delete(IToken from, IToken to)
		{
			this.delete("default", from, to);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000054B1 File Offset: 0x000036B1
		public void delete(string programName, int from, int to)
		{
			this.replace(programName, from, to, null);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000054BD File Offset: 0x000036BD
		public void delete(string programName, IToken from, IToken to)
		{
			this.replace(programName, from, to, null);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000054C9 File Offset: 0x000036C9
		public void discard(int ttype)
		{
			this.discardMask.add(ttype);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000054D7 File Offset: 0x000036D7
		public TokenWithIndex getToken(int i)
		{
			return (TokenWithIndex)this.tokens[i];
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000054EA File Offset: 0x000036EA
		public int getTokenStreamSize()
		{
			return this.tokens.Count;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000054F7 File Offset: 0x000036F7
		public string ToOriginalString()
		{
			return this.ToOriginalString(0, this.getTokenStreamSize() - 1);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00005508 File Offset: 0x00003708
		public string ToOriginalString(int start, int end)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = start;
			while (num >= 0 && num <= end && num < this.tokens.Count)
			{
				stringBuilder.Append(this.getToken(num).getText());
				num++;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00005552 File Offset: 0x00003752
		public override string ToString()
		{
			return this.ToString(0, this.getTokenStreamSize());
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00005561 File Offset: 0x00003761
		public string ToString(string programName)
		{
			return this.ToString(programName, 0, this.getTokenStreamSize());
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00005571 File Offset: 0x00003771
		public string ToString(int start, int end)
		{
			return this.ToString("default", start, end);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00005580 File Offset: 0x00003780
		public string ToString(string programName, int start, int end)
		{
			IList list = (IList)this.programs[programName];
			if (list == null)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			int num2 = start;
			while (num2 >= 0 && num2 <= end && num2 < this.tokens.Count)
			{
				if (num < list.Count)
				{
					TokenStreamRewriteEngine.RewriteOperation rewriteOperation = (TokenStreamRewriteEngine.RewriteOperation)list[num];
					while (num2 == rewriteOperation.index && num < list.Count)
					{
						num2 = rewriteOperation.execute(stringBuilder);
						num++;
						if (num < list.Count)
						{
							rewriteOperation = (TokenStreamRewriteEngine.RewriteOperation)list[num];
						}
					}
				}
				if (num2 < end)
				{
					stringBuilder.Append(this.getToken(num2).getText());
					num2++;
				}
			}
			for (int i = num; i < list.Count; i++)
			{
				TokenStreamRewriteEngine.RewriteOperation rewriteOperation2 = (TokenStreamRewriteEngine.RewriteOperation)list[i];
				rewriteOperation2.execute(stringBuilder);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00005667 File Offset: 0x00003867
		public string ToDebugString()
		{
			return this.ToDebugString(0, this.getTokenStreamSize());
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00005678 File Offset: 0x00003878
		public string ToDebugString(int start, int end)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = start;
			while (num >= 0 && num <= end && num < this.tokens.Count)
			{
				stringBuilder.Append(this.getToken(num));
				num++;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000056BD File Offset: 0x000038BD
		public int getLastRewriteTokenIndex()
		{
			return this.getLastRewriteTokenIndex("default");
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000056CC File Offset: 0x000038CC
		protected int getLastRewriteTokenIndex(string programName)
		{
			object obj = this.lastRewriteTokenIndexes[programName];
			if (obj == null)
			{
				return -1;
			}
			return (int)obj;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000056F1 File Offset: 0x000038F1
		protected void setLastRewriteTokenIndex(string programName, int i)
		{
			this.lastRewriteTokenIndexes[programName] = i;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00005708 File Offset: 0x00003908
		protected IList getProgram(string name)
		{
			IList list = (IList)this.programs[name];
			if (list == null)
			{
				list = this.initializeProgram(name);
			}
			return list;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00005734 File Offset: 0x00003934
		private IList initializeProgram(string name)
		{
			IList list = new ArrayList(100);
			this.programs[name] = list;
			return list;
		}

		// Token: 0x040000B4 RID: 180
		public const int MIN_TOKEN_INDEX = 0;

		// Token: 0x040000B5 RID: 181
		public const string DEFAULT_PROGRAM_NAME = "default";

		// Token: 0x040000B6 RID: 182
		public const int PROGRAM_INIT_SIZE = 100;

		// Token: 0x040000B7 RID: 183
		protected IList tokens;

		// Token: 0x040000B8 RID: 184
		protected IDictionary programs;

		// Token: 0x040000B9 RID: 185
		protected IDictionary lastRewriteTokenIndexes;

		// Token: 0x040000BA RID: 186
		protected int _index;

		// Token: 0x040000BB RID: 187
		protected TokenStream stream;

		// Token: 0x040000BC RID: 188
		protected BitSet discardMask = new BitSet();

		// Token: 0x0200002C RID: 44
		protected class RewriteOperation
		{
			// Token: 0x06000182 RID: 386 RVA: 0x00005757 File Offset: 0x00003957
			protected RewriteOperation(int index, string text)
			{
				this.index = index;
				this.text = text;
			}

			// Token: 0x06000183 RID: 387 RVA: 0x0000576D File Offset: 0x0000396D
			public virtual int execute(StringBuilder buf)
			{
				return this.index;
			}

			// Token: 0x040000BD RID: 189
			protected internal int index;

			// Token: 0x040000BE RID: 190
			protected internal string text;
		}

		// Token: 0x0200002D RID: 45
		protected class InsertBeforeOp : TokenStreamRewriteEngine.RewriteOperation
		{
			// Token: 0x06000184 RID: 388 RVA: 0x00005775 File Offset: 0x00003975
			public InsertBeforeOp(int index, string text) : base(index, text)
			{
			}

			// Token: 0x06000185 RID: 389 RVA: 0x0000577F File Offset: 0x0000397F
			public override int execute(StringBuilder buf)
			{
				buf.Append(this.text);
				return this.index;
			}
		}

		// Token: 0x0200002E RID: 46
		protected class ReplaceOp : TokenStreamRewriteEngine.RewriteOperation
		{
			// Token: 0x06000186 RID: 390 RVA: 0x00005794 File Offset: 0x00003994
			public ReplaceOp(int from, int to, string text) : base(from, text)
			{
				this.lastIndex = to;
			}

			// Token: 0x06000187 RID: 391 RVA: 0x000057A5 File Offset: 0x000039A5
			public override int execute(StringBuilder buf)
			{
				if (this.text != null)
				{
					buf.Append(this.text);
				}
				return this.lastIndex + 1;
			}

			// Token: 0x040000BF RID: 191
			protected int lastIndex;
		}

		// Token: 0x0200002F RID: 47
		protected class DeleteOp : TokenStreamRewriteEngine.ReplaceOp
		{
			// Token: 0x06000188 RID: 392 RVA: 0x000057C4 File Offset: 0x000039C4
			public DeleteOp(int from, int to) : base(from, to, null)
			{
			}
		}

		// Token: 0x02000030 RID: 48
		internal class RewriteOperationComparer : IComparer
		{
			// Token: 0x06000189 RID: 393 RVA: 0x000057D0 File Offset: 0x000039D0
			public virtual int Compare(object o1, object o2)
			{
				TokenStreamRewriteEngine.RewriteOperation rewriteOperation = (TokenStreamRewriteEngine.RewriteOperation)o1;
				TokenStreamRewriteEngine.RewriteOperation rewriteOperation2 = (TokenStreamRewriteEngine.RewriteOperation)o2;
				if (rewriteOperation.index < rewriteOperation2.index)
				{
					return -1;
				}
				if (rewriteOperation.index > rewriteOperation2.index)
				{
					return 1;
				}
				return 0;
			}

			// Token: 0x040000C0 RID: 192
			public static readonly TokenStreamRewriteEngine.RewriteOperationComparer Default = new TokenStreamRewriteEngine.RewriteOperationComparer();
		}
	}
}
