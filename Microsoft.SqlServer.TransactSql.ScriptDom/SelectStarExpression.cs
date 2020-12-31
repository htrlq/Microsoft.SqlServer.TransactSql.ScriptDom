using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000400 RID: 1024
	[Serializable]
	public class SelectStarExpression : SelectElement
	{
		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060036DE RID: 14046 RVA: 0x001D5E7F File Offset: 0x001D407F
		// (set) Token: 0x060036DF RID: 14047 RVA: 0x001D5E87 File Offset: 0x001D4087
		public MultiPartIdentifier Qualifier
		{
			get
			{
				return this._qualifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._qualifier = value;
			}
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x001D5E97 File Offset: 0x001D4097
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x001D5EA3 File Offset: 0x001D40A3
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Qualifier != null)
			{
				this.Qualifier.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400212D RID: 8493
		private MultiPartIdentifier _qualifier;
	}
}
