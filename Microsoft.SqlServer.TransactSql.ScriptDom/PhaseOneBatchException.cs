using System;
using System.Runtime.Serialization;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000110 RID: 272
	[Serializable]
	internal sealed class PhaseOneBatchException : Exception
	{
		// Token: 0x060002C3 RID: 707 RVA: 0x00008E05 File Offset: 0x00007005
		public PhaseOneBatchException()
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00008E0D File Offset: 0x0000700D
		private PhaseOneBatchException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
