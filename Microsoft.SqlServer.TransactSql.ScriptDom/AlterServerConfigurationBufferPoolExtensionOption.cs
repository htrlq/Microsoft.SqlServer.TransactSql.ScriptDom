using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004C3 RID: 1219
	[Serializable]
	public class AlterServerConfigurationBufferPoolExtensionOption : TSqlFragment
	{
		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x001DA005 File Offset: 0x001D8205
		// (set) Token: 0x06003B25 RID: 15141 RVA: 0x001DA00D File Offset: 0x001D820D
		public AlterServerConfigurationBufferPoolExtensionOptionKind OptionKind
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

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06003B26 RID: 15142 RVA: 0x001DA016 File Offset: 0x001D8216
		// (set) Token: 0x06003B27 RID: 15143 RVA: 0x001DA01E File Offset: 0x001D821E
		public OptionValue OptionValue
		{
			get
			{
				return this._optionValue;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._optionValue = value;
			}
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x001DA02E File Offset: 0x001D822E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x001DA03A File Offset: 0x001D823A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.OptionValue != null)
			{
				this.OptionValue.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400224A RID: 8778
		private AlterServerConfigurationBufferPoolExtensionOptionKind _optionKind;

		// Token: 0x0400224B RID: 8779
		private OptionValue _optionValue;
	}
}
