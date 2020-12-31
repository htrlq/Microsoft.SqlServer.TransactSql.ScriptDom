using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002A7 RID: 679
	[Serializable]
	public abstract class TableOption : TSqlFragment
	{
		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06002E78 RID: 11896 RVA: 0x001CD312 File Offset: 0x001CB512
		// (set) Token: 0x06002E79 RID: 11897 RVA: 0x001CD31A File Offset: 0x001CB51A
		public TableOptionKind OptionKind
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

		// Token: 0x06002E7A RID: 11898 RVA: 0x001CD323 File Offset: 0x001CB523
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EB9 RID: 7865
		private TableOptionKind _optionKind;
	}
}
