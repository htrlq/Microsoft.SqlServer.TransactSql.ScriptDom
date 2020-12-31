using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002D8 RID: 728
	[Serializable]
	public class IndexStateOption : IndexOption
	{
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06002FB2 RID: 12210 RVA: 0x001CE952 File Offset: 0x001CCB52
		// (set) Token: 0x06002FB3 RID: 12211 RVA: 0x001CE95A File Offset: 0x001CCB5A
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

		// Token: 0x06002FB4 RID: 12212 RVA: 0x001CE963 File Offset: 0x001CCB63
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x001CE96F File Offset: 0x001CCB6F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F19 RID: 7961
		private OptionState _optionState;
	}
}
