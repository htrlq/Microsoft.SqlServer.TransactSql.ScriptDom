using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002B2 RID: 690
	[Serializable]
	public abstract class TableSwitchOption : TSqlFragment
	{
		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06002EBA RID: 11962 RVA: 0x001CD6E6 File Offset: 0x001CB8E6
		// (set) Token: 0x06002EBB RID: 11963 RVA: 0x001CD6EE File Offset: 0x001CB8EE
		public TableSwitchOptionKind OptionKind
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

		// Token: 0x06002EBC RID: 11964 RVA: 0x001CD6F7 File Offset: 0x001CB8F7
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001ECB RID: 7883
		private TableSwitchOptionKind _optionKind;
	}
}
