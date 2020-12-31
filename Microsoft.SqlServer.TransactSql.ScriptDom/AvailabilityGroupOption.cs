using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004D7 RID: 1239
	[Serializable]
	public abstract class AvailabilityGroupOption : TSqlFragment
	{
		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06003B90 RID: 15248 RVA: 0x001DA6A8 File Offset: 0x001D88A8
		// (set) Token: 0x06003B91 RID: 15249 RVA: 0x001DA6B0 File Offset: 0x001D88B0
		public AvailabilityGroupOptionKind OptionKind
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

		// Token: 0x06003B92 RID: 15250 RVA: 0x001DA6B9 File Offset: 0x001D88B9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002267 RID: 8807
		private AvailabilityGroupOptionKind _optionKind;
	}
}
