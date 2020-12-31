using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001F6 RID: 502
	[Serializable]
	public class TableDefinition : TSqlFragment
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x001C86C0 File Offset: 0x001C68C0
		public IList<ColumnDefinition> ColumnDefinitions
		{
			get
			{
				return this._columnDefinitions;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06002A45 RID: 10821 RVA: 0x001C86C8 File Offset: 0x001C68C8
		public IList<ConstraintDefinition> TableConstraints
		{
			get
			{
				return this._tableConstraints;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06002A46 RID: 10822 RVA: 0x001C86D0 File Offset: 0x001C68D0
		public IList<IndexDefinition> Indexes
		{
			get
			{
				return this._indexes;
			}
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x001C86D8 File Offset: 0x001C68D8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x001C86E4 File Offset: 0x001C68E4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.ColumnDefinitions.Count;
			while (i < count)
			{
				this.ColumnDefinitions[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.TableConstraints.Count;
			while (j < count2)
			{
				this.TableConstraints[j].Accept(visitor);
				j++;
			}
			int k = 0;
			int count3 = this.Indexes.Count;
			while (k < count3)
			{
				this.Indexes[k].Accept(visitor);
				k++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D81 RID: 7553
		private List<ColumnDefinition> _columnDefinitions = new List<ColumnDefinition>();

		// Token: 0x04001D82 RID: 7554
		private List<ConstraintDefinition> _tableConstraints = new List<ConstraintDefinition>();

		// Token: 0x04001D83 RID: 7555
		private List<IndexDefinition> _indexes = new List<IndexDefinition>();
	}
}
