using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000E4 RID: 228
	internal class JoinHintHelper : OptionsHelper<JoinHint>
	{
		// Token: 0x06000274 RID: 628 RVA: 0x00008795 File Offset: 0x00006995
		private JoinHintHelper()
		{
			base.AddOptionMapping(JoinHint.Hash, "HASH", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(JoinHint.Loop, "LOOP", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(JoinHint.Merge, "MERGE", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(JoinHint.Remote, "REMOTE", SqlVersionFlags.TSqlAll);
		}

		// Token: 0x04000BAB RID: 2987
		internal static readonly JoinHintHelper Instance = new JoinHintHelper();
	}
}
