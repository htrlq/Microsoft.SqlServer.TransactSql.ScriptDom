using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000378 RID: 888
	[Serializable]
	public class DataCompressionOption : IndexOption
	{
		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x0600336B RID: 13163 RVA: 0x001D21F3 File Offset: 0x001D03F3
		// (set) Token: 0x0600336C RID: 13164 RVA: 0x001D21FB File Offset: 0x001D03FB
		public DataCompressionLevel CompressionLevel
		{
			get
			{
				return this._compressionLevel;
			}
			set
			{
				this._compressionLevel = value;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x0600336D RID: 13165 RVA: 0x001D2204 File Offset: 0x001D0404
		public IList<CompressionPartitionRange> PartitionRanges
		{
			get
			{
				return this._partitionRanges;
			}
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x001D220C File Offset: 0x001D040C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x001D2218 File Offset: 0x001D0418
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.PartitionRanges.Count;
			while (i < count)
			{
				this.PartitionRanges[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x0400201D RID: 8221
		private DataCompressionLevel _compressionLevel;

		// Token: 0x0400201E RID: 8222
		private List<CompressionPartitionRange> _partitionRanges = new List<CompressionPartitionRange>();
	}
}
