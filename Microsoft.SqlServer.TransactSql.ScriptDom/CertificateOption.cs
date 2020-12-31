using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003A8 RID: 936
	[Serializable]
	public class CertificateOption : TSqlFragment
	{
		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060034B3 RID: 13491 RVA: 0x001D3936 File Offset: 0x001D1B36
		// (set) Token: 0x060034B4 RID: 13492 RVA: 0x001D393E File Offset: 0x001D1B3E
		public CertificateOptionKinds Kind
		{
			get
			{
				return this._kind;
			}
			set
			{
				this._kind = value;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060034B5 RID: 13493 RVA: 0x001D3947 File Offset: 0x001D1B47
		// (set) Token: 0x060034B6 RID: 13494 RVA: 0x001D394F File Offset: 0x001D1B4F
		public Literal Value
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

		// Token: 0x060034B7 RID: 13495 RVA: 0x001D395F File Offset: 0x001D1B5F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x001D396B File Offset: 0x001D1B6B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002088 RID: 8328
		private CertificateOptionKinds _kind;

		// Token: 0x04002089 RID: 8329
		private Literal _value;
	}
}
