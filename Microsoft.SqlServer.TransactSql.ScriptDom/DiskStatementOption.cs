using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004E2 RID: 1250
	[Serializable]
	public class DiskStatementOption : TSqlFragment
	{
		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06003BD4 RID: 15316 RVA: 0x001DAAE1 File Offset: 0x001D8CE1
		// (set) Token: 0x06003BD5 RID: 15317 RVA: 0x001DAAE9 File Offset: 0x001D8CE9
		public DiskStatementOptionKind OptionKind
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

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06003BD6 RID: 15318 RVA: 0x001DAAF2 File Offset: 0x001D8CF2
		// (set) Token: 0x06003BD7 RID: 15319 RVA: 0x001DAAFA File Offset: 0x001D8CFA
		public IdentifierOrValueExpression Value
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

		// Token: 0x06003BD8 RID: 15320 RVA: 0x001DAB0A File Offset: 0x001D8D0A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x001DAB16 File Offset: 0x001D8D16
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400227A RID: 8826
		private DiskStatementOptionKind _optionKind;

		// Token: 0x0400227B RID: 8827
		private IdentifierOrValueExpression _value;
	}
}
