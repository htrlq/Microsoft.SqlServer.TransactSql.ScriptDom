using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001E5 RID: 485
	[Serializable]
	public class FunctionOption : TSqlFragment
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x001C819C File Offset: 0x001C639C
		// (set) Token: 0x060029F4 RID: 10740 RVA: 0x001C81A4 File Offset: 0x001C63A4
		public FunctionOptionKind OptionKind
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

		// Token: 0x060029F5 RID: 10741 RVA: 0x001C81AD File Offset: 0x001C63AD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x001C81B9 File Offset: 0x001C63B9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D6E RID: 7534
		private FunctionOptionKind _optionKind;
	}
}
