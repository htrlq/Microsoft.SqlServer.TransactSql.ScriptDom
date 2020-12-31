using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000480 RID: 1152
	[Serializable]
	public abstract class AuditOption : TSqlFragment
	{
		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060039AE RID: 14766 RVA: 0x001D8999 File Offset: 0x001D6B99
		// (set) Token: 0x060039AF RID: 14767 RVA: 0x001D89A1 File Offset: 0x001D6BA1
		public AuditOptionKind OptionKind
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

		// Token: 0x060039B0 RID: 14768 RVA: 0x001D89AA File Offset: 0x001D6BAA
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021E7 RID: 8679
		private AuditOptionKind _optionKind;
	}
}
