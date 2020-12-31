using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000388 RID: 904
	[Serializable]
	public class BackupOption : TSqlFragment
	{
		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060033E0 RID: 13280 RVA: 0x001D2A89 File Offset: 0x001D0C89
		// (set) Token: 0x060033E1 RID: 13281 RVA: 0x001D2A91 File Offset: 0x001D0C91
		public BackupOptionKind OptionKind
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

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060033E2 RID: 13282 RVA: 0x001D2A9A File Offset: 0x001D0C9A
		// (set) Token: 0x060033E3 RID: 13283 RVA: 0x001D2AA2 File Offset: 0x001D0CA2
		public ScalarExpression Value
		{
			get
			{
				return this._value;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._value = value;
			}
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x001D2AB2 File Offset: 0x001D0CB2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x001D2ABE File Offset: 0x001D0CBE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002046 RID: 8262
		private BackupOptionKind _optionKind;

		// Token: 0x04002047 RID: 8263
		private ScalarExpression _value;
	}
}
