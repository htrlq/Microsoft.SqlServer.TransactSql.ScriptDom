using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000430 RID: 1072
	[Serializable]
	public class PrincipalOption : TSqlFragment
	{
		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060037ED RID: 14317 RVA: 0x001D6E45 File Offset: 0x001D5045
		// (set) Token: 0x060037EE RID: 14318 RVA: 0x001D6E4D File Offset: 0x001D504D
		public PrincipalOptionKind OptionKind
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

		// Token: 0x060037EF RID: 14319 RVA: 0x001D6E56 File Offset: 0x001D5056
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x001D6E62 File Offset: 0x001D5062
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002171 RID: 8561
		private PrincipalOptionKind _optionKind;
	}
}
