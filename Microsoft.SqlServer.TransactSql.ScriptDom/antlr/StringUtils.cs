using System;

namespace antlr
{
	// Token: 0x02000023 RID: 35
	internal class StringUtils
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00004B35 File Offset: 0x00002D35
		public static string stripBack(string s, char c)
		{
			while (s.Length > 0 && s[s.Length - 1] == c)
			{
				s = s.Substring(0, s.Length - 1);
			}
			return s;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00004B68 File Offset: 0x00002D68
		public static string stripBack(string s, string remove)
		{
			bool flag;
			do
			{
				flag = false;
				foreach (char c in remove)
				{
					while (s.Length > 0 && s[s.Length - 1] == c)
					{
						flag = true;
						s = s.Substring(0, s.Length - 1);
					}
				}
			}
			while (flag);
			return s;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00004BC3 File Offset: 0x00002DC3
		public static string stripFront(string s, char c)
		{
			while (s.Length > 0 && s[0] == c)
			{
				s = s.Substring(1);
			}
			return s;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00004BE4 File Offset: 0x00002DE4
		public static string stripFront(string s, string remove)
		{
			bool flag;
			do
			{
				flag = false;
				foreach (char c in remove)
				{
					while (s.Length > 0 && s[0] == c)
					{
						flag = true;
						s = s.Substring(1);
					}
				}
			}
			while (flag);
			return s;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00004C30 File Offset: 0x00002E30
		public static string stripFrontBack(string src, string head, string tail)
		{
			int num = src.IndexOf(head, StringComparison.Ordinal);
			int num2 = src.LastIndexOf(tail, StringComparison.Ordinal);
			if (num == -1 || num2 == -1)
			{
				return src;
			}
			return src.Substring(num + 1, num2 - (num + 1));
		}
	}
}
