using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002A3 RID: 675
	[Serializable]
	public class AlterTableRebuildStatement : AlterTableStatement
	{
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06002E62 RID: 11874 RVA: 0x001CD176 File Offset: 0x001CB376
		// (set) Token: 0x06002E63 RID: 11875 RVA: 0x001CD17E File Offset: 0x001CB37E
		public PartitionSpecifier Partition
		{
			get
			{
				return this._partition;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._partition = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06002E64 RID: 11876 RVA: 0x001CD18E File Offset: 0x001CB38E
		public IList<IndexOption> IndexOptions
		{
			get
			{
				return this._indexOptions;
			}
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x001CD196 File Offset: 0x001CB396
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x001CD1A4 File Offset: 0x001CB3A4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.SchemaObjectName != null)
			{
				base.SchemaObjectName.Accept(visitor);
			}
			if (this.Partition != null)
			{
				this.Partition.Accept(visitor);
			}
			int i = 0;
			int count = this.IndexOptions.Count;
			while (i < count)
			{
				this.IndexOptions[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001EB3 RID: 7859
		private PartitionSpecifier _partition;

		// Token: 0x04001EB4 RID: 7860
		private List<IndexOption> _indexOptions = new List<IndexOption>();
	}
}
