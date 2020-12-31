using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000306 RID: 774
	[Serializable]
	public class CreateStatisticsStatement : TSqlStatement
	{
		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x001CF77D File Offset: 0x001CD97D
		// (set) Token: 0x060030A5 RID: 12453 RVA: 0x001CF785 File Offset: 0x001CD985
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

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060030A6 RID: 12454 RVA: 0x001CF795 File Offset: 0x001CD995
		// (set) Token: 0x060030A7 RID: 12455 RVA: 0x001CF79D File Offset: 0x001CD99D
		public SchemaObjectName OnName
		{
			get
			{
				return this._onName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._onName = value;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060030A8 RID: 12456 RVA: 0x001CF7AD File Offset: 0x001CD9AD
		public IList<ColumnReferenceExpression> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x001CF7B5 File Offset: 0x001CD9B5
		public IList<StatisticsOption> StatisticsOptions
		{
			get
			{
				return this._statisticsOptions;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060030AA RID: 12458 RVA: 0x001CF7BD File Offset: 0x001CD9BD
		// (set) Token: 0x060030AB RID: 12459 RVA: 0x001CF7C5 File Offset: 0x001CD9C5
		public BooleanExpression FilterPredicate
		{
			get
			{
				return this._filterPredicate;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._filterPredicate = value;
			}
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x001CF7D5 File Offset: 0x001CD9D5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x001CF7E4 File Offset: 0x001CD9E4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.OnName != null)
			{
				this.OnName.Accept(visitor);
			}
			int i = 0;
			int count = this.Columns.Count;
			while (i < count)
			{
				this.Columns[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.StatisticsOptions.Count;
			while (j < count2)
			{
				this.StatisticsOptions[j].Accept(visitor);
				j++;
			}
			if (this.FilterPredicate != null)
			{
				this.FilterPredicate.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F55 RID: 8021
		private Identifier _name;

		// Token: 0x04001F56 RID: 8022
		private SchemaObjectName _onName;

		// Token: 0x04001F57 RID: 8023
		private List<ColumnReferenceExpression> _columns = new List<ColumnReferenceExpression>();

		// Token: 0x04001F58 RID: 8024
		private List<StatisticsOption> _statisticsOptions = new List<StatisticsOption>();

		// Token: 0x04001F59 RID: 8025
		private BooleanExpression _filterPredicate;
	}
}
