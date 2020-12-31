using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003FC RID: 1020
	[Serializable]
	public class QuerySpecification : QueryExpression
	{
		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060036C1 RID: 14017 RVA: 0x001D5C3D File Offset: 0x001D3E3D
		// (set) Token: 0x060036C2 RID: 14018 RVA: 0x001D5C45 File Offset: 0x001D3E45
		public UniqueRowFilter UniqueRowFilter
		{
			get
			{
				return this._uniqueRowFilter;
			}
			set
			{
				this._uniqueRowFilter = value;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060036C3 RID: 14019 RVA: 0x001D5C4E File Offset: 0x001D3E4E
		// (set) Token: 0x060036C4 RID: 14020 RVA: 0x001D5C56 File Offset: 0x001D3E56
		public TopRowFilter TopRowFilter
		{
			get
			{
				return this._topRowFilter;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._topRowFilter = value;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060036C5 RID: 14021 RVA: 0x001D5C66 File Offset: 0x001D3E66
		public IList<SelectElement> SelectElements
		{
			get
			{
				return this._selectElements;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060036C6 RID: 14022 RVA: 0x001D5C6E File Offset: 0x001D3E6E
		// (set) Token: 0x060036C7 RID: 14023 RVA: 0x001D5C76 File Offset: 0x001D3E76
		public FromClause FromClause
		{
			get
			{
				return this._fromClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._fromClause = value;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060036C8 RID: 14024 RVA: 0x001D5C86 File Offset: 0x001D3E86
		// (set) Token: 0x060036C9 RID: 14025 RVA: 0x001D5C8E File Offset: 0x001D3E8E
		public WhereClause WhereClause
		{
			get
			{
				return this._whereClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._whereClause = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x001D5C9E File Offset: 0x001D3E9E
		// (set) Token: 0x060036CB RID: 14027 RVA: 0x001D5CA6 File Offset: 0x001D3EA6
		public GroupByClause GroupByClause
		{
			get
			{
				return this._groupByClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._groupByClause = value;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060036CC RID: 14028 RVA: 0x001D5CB6 File Offset: 0x001D3EB6
		// (set) Token: 0x060036CD RID: 14029 RVA: 0x001D5CBE File Offset: 0x001D3EBE
		public HavingClause HavingClause
		{
			get
			{
				return this._havingClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._havingClause = value;
			}
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x001D5CCE File Offset: 0x001D3ECE
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x001D5CDC File Offset: 0x001D3EDC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.TopRowFilter != null)
			{
				this.TopRowFilter.Accept(visitor);
			}
			int i = 0;
			int count = this.SelectElements.Count;
			while (i < count)
			{
				this.SelectElements[i].Accept(visitor);
				i++;
			}
			if (this.FromClause != null)
			{
				this.FromClause.Accept(visitor);
			}
			if (this.WhereClause != null)
			{
				this.WhereClause.Accept(visitor);
			}
			if (this.GroupByClause != null)
			{
				this.GroupByClause.Accept(visitor);
			}
			if (this.HavingClause != null)
			{
				this.HavingClause.Accept(visitor);
			}
		}

		// Token: 0x04002123 RID: 8483
		private UniqueRowFilter _uniqueRowFilter;

		// Token: 0x04002124 RID: 8484
		private TopRowFilter _topRowFilter;

		// Token: 0x04002125 RID: 8485
		private List<SelectElement> _selectElements = new List<SelectElement>();

		// Token: 0x04002126 RID: 8486
		private FromClause _fromClause;

		// Token: 0x04002127 RID: 8487
		private WhereClause _whereClause;

		// Token: 0x04002128 RID: 8488
		private GroupByClause _groupByClause;

		// Token: 0x04002129 RID: 8489
		private HavingClause _havingClause;
	}
}
