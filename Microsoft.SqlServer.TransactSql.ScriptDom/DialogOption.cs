using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000454 RID: 1108
	[Serializable]
	public abstract class DialogOption : TSqlFragment
	{
		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060038D5 RID: 14549 RVA: 0x001D7CE9 File Offset: 0x001D5EE9
		// (set) Token: 0x060038D6 RID: 14550 RVA: 0x001D7CF1 File Offset: 0x001D5EF1
		public DialogOptionKind OptionKind
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

		// Token: 0x060038D7 RID: 14551 RVA: 0x001D7CFA File Offset: 0x001D5EFA
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021B4 RID: 8628
		private DialogOptionKind _optionKind;
	}
}
