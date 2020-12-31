using System;
using System.Runtime.Serialization;

namespace antlr
{
	// Token: 0x02000022 RID: 34
	[Serializable]
	internal class SemanticException : RecognitionException
	{
		// Token: 0x06000122 RID: 290 RVA: 0x00004B15 File Offset: 0x00002D15
		public SemanticException(string s) : base(s)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00004B1E File Offset: 0x00002D1E
		public SemanticException(string s, string fileName, int line, int column) : base(s, fileName, line, column)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00004B2B File Offset: 0x00002D2B
		protected SemanticException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
