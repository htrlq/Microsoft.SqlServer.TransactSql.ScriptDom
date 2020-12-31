using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200029B RID: 667
	[Serializable]
	public class OnOffAssemblyOption : AssemblyOption
	{
		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06002E33 RID: 11827 RVA: 0x001CCEC0 File Offset: 0x001CB0C0
		// (set) Token: 0x06002E34 RID: 11828 RVA: 0x001CCEC8 File Offset: 0x001CB0C8
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

		// Token: 0x06002E35 RID: 11829 RVA: 0x001CCED1 File Offset: 0x001CB0D1
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x001CCEDD File Offset: 0x001CB0DD
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EA7 RID: 7847
		private OptionState _optionState;
	}
}
