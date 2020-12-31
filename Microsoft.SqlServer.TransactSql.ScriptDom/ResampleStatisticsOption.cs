using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000302 RID: 770
	[Serializable]
	public class ResampleStatisticsOption : StatisticsOption
	{
		// Token: 0x17000322 RID: 802
		// (get) Token: 0x0600308F RID: 12431 RVA: 0x001CF62A File Offset: 0x001CD82A
		public IList<StatisticsPartitionRange> Partitions
		{
			get
			{
				return this._partitions;
			}
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x001CF632 File Offset: 0x001CD832
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x001CF640 File Offset: 0x001CD840
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.Partitions.Count;
			while (i < count)
			{
				this.Partitions[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001F50 RID: 8016
		private List<StatisticsPartitionRange> _partitions = new List<StatisticsPartitionRange>();
	}
}
