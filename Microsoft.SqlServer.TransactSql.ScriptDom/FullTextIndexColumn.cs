using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002DF RID: 735
	[Serializable]
	public class FullTextIndexColumn : TSqlFragment
	{
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06002FD5 RID: 12245 RVA: 0x001CEB23 File Offset: 0x001CCD23
		// (set) Token: 0x06002FD6 RID: 12246 RVA: 0x001CEB2B File Offset: 0x001CCD2B
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06002FD7 RID: 12247 RVA: 0x001CEB3B File Offset: 0x001CCD3B
		// (set) Token: 0x06002FD8 RID: 12248 RVA: 0x001CEB43 File Offset: 0x001CCD43
		public Identifier TypeColumn
		{
			get
			{
				return this._typeColumn;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._typeColumn = value;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x001CEB53 File Offset: 0x001CCD53
		// (set) Token: 0x06002FDA RID: 12250 RVA: 0x001CEB5B File Offset: 0x001CCD5B
		public IdentifierOrValueExpression LanguageTerm
		{
			get
			{
				return this._languageTerm;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._languageTerm = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06002FDB RID: 12251 RVA: 0x001CEB6B File Offset: 0x001CCD6B
		// (set) Token: 0x06002FDC RID: 12252 RVA: 0x001CEB73 File Offset: 0x001CCD73
		public bool StatisticalSemantics
		{
			get
			{
				return this._statisticalSemantics;
			}
			set
			{
				this._statisticalSemantics = value;
			}
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x001CEB7C File Offset: 0x001CCD7C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x001CEB88 File Offset: 0x001CCD88
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.TypeColumn != null)
			{
				this.TypeColumn.Accept(visitor);
			}
			if (this.LanguageTerm != null)
			{
				this.LanguageTerm.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F21 RID: 7969
		private Identifier _name;

		// Token: 0x04001F22 RID: 7970
		private Identifier _typeColumn;

		// Token: 0x04001F23 RID: 7971
		private IdentifierOrValueExpression _languageTerm;

		// Token: 0x04001F24 RID: 7972
		private bool _statisticalSemantics;
	}
}
