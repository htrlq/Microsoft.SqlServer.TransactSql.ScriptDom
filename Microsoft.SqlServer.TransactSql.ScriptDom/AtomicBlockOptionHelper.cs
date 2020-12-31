using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000054 RID: 84
	[Serializable]
	internal class AtomicBlockOptionHelper : OptionsHelper<AtomicBlockOptionKind>
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x00005FAC File Offset: 0x000041AC
		private AtomicBlockOptionHelper()
		{
			base.AddOptionMapping(AtomicBlockOptionKind.DateFirst, "DATEFIRST", SqlVersionFlags.TSql120);
			base.AddOptionMapping(AtomicBlockOptionKind.DateFormat, "DATEFORMAT", SqlVersionFlags.TSql120);
			base.AddOptionMapping(AtomicBlockOptionKind.DelayedDurability, "DELAYED_DURABILITY", SqlVersionFlags.TSql120);
			base.AddOptionMapping(AtomicBlockOptionKind.IsolationLevel, "TRANSACTION ISOLATION LEVEL", SqlVersionFlags.TSql120);
			base.AddOptionMapping(AtomicBlockOptionKind.Language, "LANGUAGE", SqlVersionFlags.TSql120);
		}

		// Token: 0x0400015D RID: 349
		internal static readonly AtomicBlockOptionHelper Instance = new AtomicBlockOptionHelper();
	}
}
