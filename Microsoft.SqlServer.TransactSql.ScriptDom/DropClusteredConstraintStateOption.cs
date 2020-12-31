using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002B5 RID: 693
	[Serializable]
	public class DropClusteredConstraintStateOption : DropClusteredConstraintOption
	{
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06002EC6 RID: 11974 RVA: 0x001CD78F File Offset: 0x001CB98F
		// (set) Token: 0x06002EC7 RID: 11975 RVA: 0x001CD797 File Offset: 0x001CB997
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

		// Token: 0x06002EC8 RID: 11976 RVA: 0x001CD7A0 File Offset: 0x001CB9A0
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x001CD7AC File Offset: 0x001CB9AC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001ECE RID: 7886
		private OptionState _optionState;
	}
}
