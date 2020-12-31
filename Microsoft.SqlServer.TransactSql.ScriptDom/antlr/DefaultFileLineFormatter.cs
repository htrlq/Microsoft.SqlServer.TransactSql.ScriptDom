using System;
using System.Text;

namespace antlr
{
	// Token: 0x02000016 RID: 22
	internal class DefaultFileLineFormatter : FileLineFormatter
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00003BC0 File Offset: 0x00001DC0
		public override string getFormatString(string fileName, int line, int column)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (fileName != null)
			{
				stringBuilder.Append(fileName + ":");
			}
			if (line != -1)
			{
				if (fileName == null)
				{
					stringBuilder.Append("line ");
				}
				stringBuilder.Append(line);
				if (column != -1)
				{
					stringBuilder.Append(":" + column);
				}
				stringBuilder.Append(":");
			}
			stringBuilder.Append(" ");
			return stringBuilder.ToString();
		}
	}
}
