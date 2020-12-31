using System;

namespace antlr
{
	// Token: 0x02000015 RID: 21
	internal abstract class FileLineFormatter
	{
		// Token: 0x060000CA RID: 202 RVA: 0x00003B9C File Offset: 0x00001D9C
		public static FileLineFormatter getFormatter()
		{
			return FileLineFormatter.formatter;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003BA3 File Offset: 0x00001DA3
		public static void setFormatter(FileLineFormatter f)
		{
			FileLineFormatter.formatter = f;
		}

		// Token: 0x060000CC RID: 204
		public abstract string getFormatString(string fileName, int line, int column);

		// Token: 0x04000064 RID: 100
		private static FileLineFormatter formatter = new DefaultFileLineFormatter();
	}
}
