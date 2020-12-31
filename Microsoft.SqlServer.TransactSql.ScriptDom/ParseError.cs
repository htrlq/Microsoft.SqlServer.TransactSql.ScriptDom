using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000109 RID: 265
	[Serializable]
	public sealed class ParseError
	{
		// Token: 0x060002B9 RID: 697 RVA: 0x00008D13 File Offset: 0x00006F13
		public ParseError(int number, int offset, int line, int column, string message)
		{
			this._number = number;
			this._offset = offset;
			this._message = message;
			this._line = line;
			this._column = column;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00008D40 File Offset: 0x00006F40
		public int Number
		{
			get
			{
				return this._number;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00008D48 File Offset: 0x00006F48
		public int Offset
		{
			get
			{
				return this._offset;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00008D50 File Offset: 0x00006F50
		public int Line
		{
			get
			{
				return this._line;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00008D58 File Offset: 0x00006F58
		public int Column
		{
			get
			{
				return this._column;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00008D60 File Offset: 0x00006F60
		public string Message
		{
			get
			{
				return this._message;
			}
		}

		// Token: 0x04000C37 RID: 3127
		private readonly int _number;

		// Token: 0x04000C38 RID: 3128
		private readonly int _offset;

		// Token: 0x04000C39 RID: 3129
		private readonly int _line;

		// Token: 0x04000C3A RID: 3130
		private readonly int _column;

		// Token: 0x04000C3B RID: 3131
		private readonly string _message;
	}
}
