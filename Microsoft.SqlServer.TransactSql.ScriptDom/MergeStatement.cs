using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000467 RID: 1127
	[Serializable]
	public class MergeStatement : DataModificationStatement
	{
		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06003930 RID: 14640 RVA: 0x001D8135 File Offset: 0x001D6335
		// (set) Token: 0x06003931 RID: 14641 RVA: 0x001D813D File Offset: 0x001D633D
		public MergeSpecification MergeSpecification
		{
			get
			{
				return this._mergeSpecification;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._mergeSpecification = value;
			}
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x001D814D File Offset: 0x001D634D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x001D8159 File Offset: 0x001D6359
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.MergeSpecification != null)
			{
				this.MergeSpecification.Accept(visitor);
			}
		}

		// Token: 0x040021C7 RID: 8647
		private MergeSpecification _mergeSpecification;
	}
}
