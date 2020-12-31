using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004C7 RID: 1223
	[Serializable]
	public class AlterServerConfigurationDiagnosticsLogOption : TSqlFragment
	{
		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06003B38 RID: 15160 RVA: 0x001DA159 File Offset: 0x001D8359
		// (set) Token: 0x06003B39 RID: 15161 RVA: 0x001DA161 File Offset: 0x001D8361
		public AlterServerConfigurationDiagnosticsLogOptionKind OptionKind
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

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06003B3A RID: 15162 RVA: 0x001DA16A File Offset: 0x001D836A
		// (set) Token: 0x06003B3B RID: 15163 RVA: 0x001DA172 File Offset: 0x001D8372
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

		// Token: 0x06003B3C RID: 15164 RVA: 0x001DA182 File Offset: 0x001D8382
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x001DA18E File Offset: 0x001D838E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.OptionValue != null)
			{
				this.OptionValue.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400224F RID: 8783
		private AlterServerConfigurationDiagnosticsLogOptionKind _optionKind;

		// Token: 0x04002250 RID: 8784
		private OptionValue _optionValue;
	}
}
