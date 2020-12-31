using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200014E RID: 334
	internal class SpatialIndexingSchemeTypeHelper : OptionsHelper<SpatialIndexingSchemeType>
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x00009A56 File Offset: 0x00007C56
		private SpatialIndexingSchemeTypeHelper()
		{
			base.AddOptionMapping(SpatialIndexingSchemeType.GeographyGrid, "GEOGRAPHY_GRID");
			base.AddOptionMapping(SpatialIndexingSchemeType.GeometryGrid, "GEOMETRY_GRID");
			base.AddOptionMapping(SpatialIndexingSchemeType.GeographyAutoGrid, "GEOGRAPHY_AUTO_GRID", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(SpatialIndexingSchemeType.GeometryAutoGrid, "GEOMETRY_AUTO_GRID", SqlVersionFlags.TSql110AndAbove);
		}

		// Token: 0x04000DB2 RID: 3506
		internal static readonly SpatialIndexingSchemeTypeHelper Instance = new SpatialIndexingSchemeTypeHelper();
	}
}
