using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004CC RID: 1228
	[Serializable]
	public class AlterServerConfigurationHadrClusterOption : TSqlFragment
	{
		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06003B53 RID: 15187 RVA: 0x001DA309 File Offset: 0x001D8509
		// (set) Token: 0x06003B54 RID: 15188 RVA: 0x001DA311 File Offset: 0x001D8511
		public AlterServerConfigurationHadrClusterOptionKind OptionKind
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

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06003B55 RID: 15189 RVA: 0x001DA31A File Offset: 0x001D851A
		// (set) Token: 0x06003B56 RID: 15190 RVA: 0x001DA322 File Offset: 0x001D8522
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

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06003B57 RID: 15191 RVA: 0x001DA332 File Offset: 0x001D8532
		// (set) Token: 0x06003B58 RID: 15192 RVA: 0x001DA33A File Offset: 0x001D853A
		public bool IsLocal
		{
			get
			{
				return this._isLocal;
			}
			set
			{
				this._isLocal = value;
			}
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x001DA343 File Offset: 0x001D8543
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x001DA34F File Offset: 0x001D854F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.OptionValue != null)
			{
				this.OptionValue.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002256 RID: 8790
		private AlterServerConfigurationHadrClusterOptionKind _optionKind;

		// Token: 0x04002257 RID: 8791
		private OptionValue _optionValue;

		// Token: 0x04002258 RID: 8792
		private bool _isLocal;
	}
}
