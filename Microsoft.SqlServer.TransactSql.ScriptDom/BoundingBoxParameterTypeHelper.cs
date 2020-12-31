using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000070 RID: 112
	internal class BoundingBoxParameterTypeHelper : OptionsHelper<BoundingBoxParameterType>
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x00006BF7 File Offset: 0x00004DF7
		private BoundingBoxParameterTypeHelper()
		{
			base.AddOptionMapping(BoundingBoxParameterType.XMin, "XMIN");
			base.AddOptionMapping(BoundingBoxParameterType.YMin, "YMIN");
			base.AddOptionMapping(BoundingBoxParameterType.XMax, "XMAX");
			base.AddOptionMapping(BoundingBoxParameterType.YMax, "YMAX");
		}

		// Token: 0x0400021C RID: 540
		internal static readonly BoundingBoxParameterTypeHelper Instance = new BoundingBoxParameterTypeHelper();
	}
}
