using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002DC RID: 732
	[Serializable]
	public abstract class LowPriorityLockWaitOption : TSqlFragment
	{
		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x001CEA79 File Offset: 0x001CCC79
		// (set) Token: 0x06002FC6 RID: 12230 RVA: 0x001CEA81 File Offset: 0x001CCC81
		public LowPriorityLockWaitOptionKind OptionKind
		{
			get
			{
				return this._optionKind;
			}
			set
			{
				this._optionKind = value;
			}
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x001CEA8A File Offset: 0x001CCC8A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F1D RID: 7965
		private LowPriorityLockWaitOptionKind _optionKind;
	}
}
