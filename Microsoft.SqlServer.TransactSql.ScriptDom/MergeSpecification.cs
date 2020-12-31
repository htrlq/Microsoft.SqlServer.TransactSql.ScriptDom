using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000468 RID: 1128
	[Serializable]
	public class MergeSpecification : DataModificationSpecification
	{
		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06003935 RID: 14645 RVA: 0x001D817E File Offset: 0x001D637E
		// (set) Token: 0x06003936 RID: 14646 RVA: 0x001D8186 File Offset: 0x001D6386
		public Identifier TableAlias
		{
			get
			{
				return this._tableAlias;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._tableAlias = value;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x001D8196 File Offset: 0x001D6396
		// (set) Token: 0x06003938 RID: 14648 RVA: 0x001D819E File Offset: 0x001D639E
		public TableReference TableReference
		{
			get
			{
				return this._tableReference;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._tableReference = value;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06003939 RID: 14649 RVA: 0x001D81AE File Offset: 0x001D63AE
		// (set) Token: 0x0600393A RID: 14650 RVA: 0x001D81B6 File Offset: 0x001D63B6
		public BooleanExpression SearchCondition
		{
			get
			{
				return this._searchCondition;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._searchCondition = value;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x0600393B RID: 14651 RVA: 0x001D81C6 File Offset: 0x001D63C6
		public IList<MergeActionClause> ActionClauses
		{
			get
			{
				return this._actionClauses;
			}
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x001D81CE File Offset: 0x001D63CE
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x001D81DC File Offset: 0x001D63DC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.TableAlias != null)
			{
				this.TableAlias.Accept(visitor);
			}
			if (this.TableReference != null)
			{
				this.TableReference.Accept(visitor);
			}
			if (this.SearchCondition != null)
			{
				this.SearchCondition.Accept(visitor);
			}
			int i = 0;
			int count = this.ActionClauses.Count;
			while (i < count)
			{
				this.ActionClauses[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x040021C8 RID: 8648
		private Identifier _tableAlias;

		// Token: 0x040021C9 RID: 8649
		private TableReference _tableReference;

		// Token: 0x040021CA RID: 8650
		private BooleanExpression _searchCondition;

		// Token: 0x040021CB RID: 8651
		private List<MergeActionClause> _actionClauses = new List<MergeActionClause>();
	}
}
