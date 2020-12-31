using System;
using System.Runtime.Serialization;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000179 RID: 377
	[Serializable]
	internal sealed class TSqlParseErrorException : Exception
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0001F55F File Offset: 0x0001D75F
		public bool DoNotLog
		{
			get
			{
				return this._doNotLog;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0001F567 File Offset: 0x0001D767
		public ParseError ParseError
		{
			get
			{
				return this._parseError;
			}
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0001F56F File Offset: 0x0001D76F
		public TSqlParseErrorException(ParseError error, bool doNotLog)
		{
			this._parseError = error;
			this._doNotLog = doNotLog;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0001F585 File Offset: 0x0001D785
		public TSqlParseErrorException(ParseError error) : this(error, false)
		{
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0001F58F File Offset: 0x0001D78F
		private TSqlParseErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000F71 RID: 3953
		private ParseError _parseError;

		// Token: 0x04000F72 RID: 3954
		private bool _doNotLog;
	}
}
