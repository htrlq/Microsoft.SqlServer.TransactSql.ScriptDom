using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003CB RID: 971
	[Serializable]
	public abstract class KeyOption : TSqlFragment
	{
		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x0600359C RID: 13724 RVA: 0x001D47A8 File Offset: 0x001D29A8
		// (set) Token: 0x0600359D RID: 13725 RVA: 0x001D47B0 File Offset: 0x001D29B0
		public KeyOptionKind OptionKind
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

		// Token: 0x0600359E RID: 13726 RVA: 0x001D47B9 File Offset: 0x001D29B9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020CE RID: 8398
		private KeyOptionKind _optionKind;
	}
}
