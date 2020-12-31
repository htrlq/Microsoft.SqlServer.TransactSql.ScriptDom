using System;
using System.Runtime.Serialization;

namespace antlr
{
	// Token: 0x02000029 RID: 41
	[Serializable]
	internal class TokenStreamRecognitionException : TokenStreamException
	{
		// Token: 0x06000150 RID: 336 RVA: 0x000051A1 File Offset: 0x000033A1
		public TokenStreamRecognitionException(RecognitionException re) : base(re.Message)
		{
			this.recog = re;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000051B6 File Offset: 0x000033B6
		protected TokenStreamRecognitionException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000051C0 File Offset: 0x000033C0
		public override string ToString()
		{
			return this.recog.ToString();
		}

		// Token: 0x040000B3 RID: 179
		public RecognitionException recog;
	}
}
