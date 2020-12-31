using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000089 RID: 137
	internal class CursorOptionsHelper : OptionsHelper<CursorOptionKind>
	{
		// Token: 0x0600020A RID: 522 RVA: 0x0000721C File Offset: 0x0000541C
		private CursorOptionsHelper()
		{
			base.AddOptionMapping(CursorOptionKind.Local, "LOCAL");
			base.AddOptionMapping(CursorOptionKind.Global, "GLOBAL");
			base.AddOptionMapping(CursorOptionKind.Scroll, "SCROLL");
			base.AddOptionMapping(CursorOptionKind.ForwardOnly, "FORWARD_ONLY");
			base.AddOptionMapping(CursorOptionKind.Insensitive, "INSENSITIVE");
			base.AddOptionMapping(CursorOptionKind.Keyset, "KEYSET");
			base.AddOptionMapping(CursorOptionKind.Dynamic, "DYNAMIC");
			base.AddOptionMapping(CursorOptionKind.FastForward, "FAST_FORWARD");
			base.AddOptionMapping(CursorOptionKind.ScrollLocks, "SCROLL_LOCKS");
			base.AddOptionMapping(CursorOptionKind.Optimistic, "OPTIMISTIC");
			base.AddOptionMapping(CursorOptionKind.ReadOnly, "READ_ONLY");
			base.AddOptionMapping(CursorOptionKind.Static, "STATIC");
			base.AddOptionMapping(CursorOptionKind.TypeWarning, "TYPE_WARNING");
		}

		// Token: 0x04000825 RID: 2085
		internal static readonly CursorOptionsHelper Instance = new CursorOptionsHelper();
	}
}
