using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200035A RID: 858
	[Serializable]
	public class OnOffDatabaseOption : DatabaseOption
	{
		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x0600329A RID: 12954 RVA: 0x001D1623 File Offset: 0x001CF823
		// (set) Token: 0x0600329B RID: 12955 RVA: 0x001D162B File Offset: 0x001CF82B
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

		// Token: 0x0600329C RID: 12956 RVA: 0x001D1634 File Offset: 0x001CF834
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x001D1640 File Offset: 0x001CF840
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FDF RID: 8159
		private OptionState _optionState;
	}
}
