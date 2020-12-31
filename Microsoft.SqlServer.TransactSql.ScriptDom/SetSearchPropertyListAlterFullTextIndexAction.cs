using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000423 RID: 1059
	[Serializable]
	public class SetSearchPropertyListAlterFullTextIndexAction : AlterFullTextIndexAction
	{
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x0600379B RID: 14235 RVA: 0x001D68F2 File Offset: 0x001D4AF2
		// (set) Token: 0x0600379C RID: 14236 RVA: 0x001D68FA File Offset: 0x001D4AFA
		public SearchPropertyListFullTextIndexOption SearchPropertyListOption
		{
			get
			{
				return this._searchPropertyListOption;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._searchPropertyListOption = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x0600379D RID: 14237 RVA: 0x001D690A File Offset: 0x001D4B0A
		// (set) Token: 0x0600379E RID: 14238 RVA: 0x001D6912 File Offset: 0x001D4B12
		public bool WithNoPopulation
		{
			get
			{
				return this._withNoPopulation;
			}
			set
			{
				this._withNoPopulation = value;
			}
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x001D691B File Offset: 0x001D4B1B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x001D6927 File Offset: 0x001D4B27
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SearchPropertyListOption != null)
			{
				this.SearchPropertyListOption.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002159 RID: 8537
		private SearchPropertyListFullTextIndexOption _searchPropertyListOption;

		// Token: 0x0400215A RID: 8538
		private bool _withNoPopulation;
	}
}
