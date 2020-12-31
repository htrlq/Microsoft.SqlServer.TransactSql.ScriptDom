using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004C0 RID: 1216
	[Serializable]
	public class AlterServerConfigurationStatement : TSqlStatement
	{
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06003B17 RID: 15127 RVA: 0x001D9F09 File Offset: 0x001D8109
		// (set) Token: 0x06003B18 RID: 15128 RVA: 0x001D9F11 File Offset: 0x001D8111
		public ProcessAffinityType ProcessAffinity
		{
			get
			{
				return this._processAffinity;
			}
			set
			{
				this._processAffinity = value;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06003B19 RID: 15129 RVA: 0x001D9F1A File Offset: 0x001D811A
		public IList<ProcessAffinityRange> ProcessAffinityRanges
		{
			get
			{
				return this._processAffinityRanges;
			}
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x001D9F22 File Offset: 0x001D8122
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x001D9F30 File Offset: 0x001D8130
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.ProcessAffinityRanges.Count;
			while (i < count)
			{
				this.ProcessAffinityRanges[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002247 RID: 8775
		private ProcessAffinityType _processAffinity;

		// Token: 0x04002248 RID: 8776
		private List<ProcessAffinityRange> _processAffinityRanges = new List<ProcessAffinityRange>();
	}
}
