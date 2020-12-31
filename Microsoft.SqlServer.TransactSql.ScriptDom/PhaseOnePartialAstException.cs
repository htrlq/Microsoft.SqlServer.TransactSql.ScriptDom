using System;
using System.Runtime.Serialization;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000112 RID: 274
	[Serializable]
	internal sealed class PhaseOnePartialAstException : Exception
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00008E38 File Offset: 0x00007038
		public TSqlStatement Statement
		{
			get
			{
				return this._statement;
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00008E40 File Offset: 0x00007040
		public PhaseOnePartialAstException(TSqlStatement statement)
		{
			this._statement = statement;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00008E4F File Offset: 0x0000704F
		private PhaseOnePartialAstException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000C68 RID: 3176
		private TSqlStatement _statement;
	}
}
