using System;
using System.Runtime.Serialization;

namespace antlr
{
	// Token: 0x0200001A RID: 26
	[Serializable]
	internal class RecognitionException : ANTLRException
	{
		// Token: 0x06000103 RID: 259 RVA: 0x00004294 File Offset: 0x00002494
		public RecognitionException() : base("parsing error")
		{
			this.fileName = null;
			this.line = -1;
			this.column = -1;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000042B6 File Offset: 0x000024B6
		public RecognitionException(string s) : base(s)
		{
			this.fileName = null;
			this.line = -1;
			this.column = -1;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000042D4 File Offset: 0x000024D4
		public RecognitionException(string s, string fileName_, int line_, int column_) : base(s)
		{
			this.fileName = fileName_;
			this.line = line_;
			this.column = column_;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000042F3 File Offset: 0x000024F3
		protected RecognitionException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000042FD File Offset: 0x000024FD
		public virtual string getFilename()
		{
			return this.fileName;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00004305 File Offset: 0x00002505
		public virtual int getLine()
		{
			return this.line;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000430D File Offset: 0x0000250D
		public virtual int getColumn()
		{
			return this.column;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00004315 File Offset: 0x00002515
		public override string ToString()
		{
			return FileLineFormatter.getFormatter().getFormatString(this.fileName, this.line, this.column) + this.Message;
		}

		// Token: 0x04000081 RID: 129
		public string fileName;

		// Token: 0x04000082 RID: 130
		public int line;

		// Token: 0x04000083 RID: 131
		public int column;
	}
}
