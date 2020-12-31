using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002C3 RID: 707
	[Serializable]
	public class QueueStateOption : QueueOption
	{
		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06002F1D RID: 12061 RVA: 0x001CDD34 File Offset: 0x001CBF34
		// (set) Token: 0x06002F1E RID: 12062 RVA: 0x001CDD3C File Offset: 0x001CBF3C
		public OptionState OptionState
		{
			get
			{
				return this._optionState;
			}
			set
			{
				this._optionState = value;
			}
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x001CDD45 File Offset: 0x001CBF45
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x001CDD51 File Offset: 0x001CBF51
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EE7 RID: 7911
		private OptionState _optionState;
	}
}
