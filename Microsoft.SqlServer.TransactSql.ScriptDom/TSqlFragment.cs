using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200007B RID: 123
	[Serializable]
	public abstract class TSqlFragment
	{
		// Token: 0x060001DF RID: 479 RVA: 0x00006E05 File Offset: 0x00005005
		internal void UpdateTokenInfo(TSqlFragment fragment)
		{
			if (fragment == null)
			{
				return;
			}
			this.UpdateTokenInfo(fragment.FirstTokenIndex, fragment.LastTokenIndex);
			if (fragment.ScriptTokenStream != null)
			{
				this.ScriptTokenStream = fragment.ScriptTokenStream;
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00006E34 File Offset: 0x00005034
		internal void UpdateTokenInfo(int firstIndex, int lastIndex)
		{
			if (firstIndex < 0 || lastIndex < 0)
			{
				return;
			}
			if (firstIndex > lastIndex)
			{
				int num = firstIndex;
				firstIndex = lastIndex;
				lastIndex = num;
			}
			if (firstIndex < this._firstTokenIndex || this._firstTokenIndex == -1)
			{
				this._firstTokenIndex = firstIndex;
			}
			if (lastIndex > this._lastTokenIndex || this._lastTokenIndex == -1)
			{
				this._lastTokenIndex = lastIndex;
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00006E88 File Offset: 0x00005088
		public virtual void Accept(TSqlFragmentVisitor visitor)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00006E8A File Offset: 0x0000508A
		public virtual void AcceptChildren(TSqlFragmentVisitor visitor)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00006E8C File Offset: 0x0000508C
		public int StartOffset
		{
			get
			{
				if (this._firstTokenIndex == -1 || this._scriptTokenStream == null)
				{
					return -1;
				}
				return this._scriptTokenStream[this._firstTokenIndex].Offset;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00006EB8 File Offset: 0x000050B8
		public int FragmentLength
		{
			get
			{
				if (this._firstTokenIndex == -1 || this._lastTokenIndex == -1 || this._scriptTokenStream == null)
				{
					return -1;
				}
				TSqlParserToken tsqlParserToken = this._scriptTokenStream[this._lastTokenIndex];
				int num = (tsqlParserToken.Text == null) ? 0 : tsqlParserToken.Text.Length;
				return tsqlParserToken.Offset - this._scriptTokenStream[this._firstTokenIndex].Offset + num;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00006F29 File Offset: 0x00005129
		public int StartLine
		{
			get
			{
				if (this._firstTokenIndex == -1 || this._scriptTokenStream == null)
				{
					return -1;
				}
				return this._scriptTokenStream[this._firstTokenIndex].Line;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00006F54 File Offset: 0x00005154
		public int StartColumn
		{
			get
			{
				if (this._firstTokenIndex == -1 || this._scriptTokenStream == null)
				{
					return -1;
				}
				return this._scriptTokenStream[this._firstTokenIndex].Column;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00006F7F File Offset: 0x0000517F
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00006F87 File Offset: 0x00005187
		public int FirstTokenIndex
		{
			get
			{
				return this._firstTokenIndex;
			}
			set
			{
				this._firstTokenIndex = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00006F90 File Offset: 0x00005190
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00006F98 File Offset: 0x00005198
		public int LastTokenIndex
		{
			get
			{
				return this._lastTokenIndex;
			}
			set
			{
				this._lastTokenIndex = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00006FA1 File Offset: 0x000051A1
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00006FA9 File Offset: 0x000051A9
		public IList<TSqlParserToken> ScriptTokenStream
		{
			get
			{
				return this._scriptTokenStream;
			}
			set
			{
				this._scriptTokenStream = value;
			}
		}

		// Token: 0x0400024F RID: 591
		public const int Uninitialized = -1;

		// Token: 0x04000250 RID: 592
		private int _firstTokenIndex = -1;

		// Token: 0x04000251 RID: 593
		private int _lastTokenIndex = -1;

		// Token: 0x04000252 RID: 594
		private IList<TSqlParserToken> _scriptTokenStream;
	}
}
