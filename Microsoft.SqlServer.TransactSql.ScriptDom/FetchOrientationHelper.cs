using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000C2 RID: 194
	internal class FetchOrientationHelper : OptionsHelper<FetchOrientation>
	{
		// Token: 0x06000236 RID: 566 RVA: 0x00008070 File Offset: 0x00006270
		private FetchOrientationHelper()
		{
			base.AddOptionMapping(FetchOrientation.First, "FIRST");
			base.AddOptionMapping(FetchOrientation.Next, "NEXT");
			base.AddOptionMapping(FetchOrientation.Prior, "PRIOR");
			base.AddOptionMapping(FetchOrientation.Last, "LAST");
			base.AddOptionMapping(FetchOrientation.Relative, "RELATIVE");
			base.AddOptionMapping(FetchOrientation.Absolute, "ABSOLUTE");
		}

		// Token: 0x04000B23 RID: 2851
		internal static readonly FetchOrientationHelper Instance = new FetchOrientationHelper();
	}
}
