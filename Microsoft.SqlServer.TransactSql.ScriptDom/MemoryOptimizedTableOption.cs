using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002AD RID: 685
	[Serializable]
	public class MemoryOptimizedTableOption : TableOption
	{
		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06002E95 RID: 11925 RVA: 0x001CD486 File Offset: 0x001CB686
		// (set) Token: 0x06002E96 RID: 11926 RVA: 0x001CD48E File Offset: 0x001CB68E
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

		// Token: 0x06002E97 RID: 11927 RVA: 0x001CD497 File Offset: 0x001CB697
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x001CD4A3 File Offset: 0x001CB6A3
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EBF RID: 7871
		private OptionState _optionState;
	}
}
