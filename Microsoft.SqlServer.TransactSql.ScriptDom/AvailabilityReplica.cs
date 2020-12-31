using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004D0 RID: 1232
	[Serializable]
	public class AvailabilityReplica : TSqlFragment
	{
		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06003B6D RID: 15213 RVA: 0x001DA4F1 File Offset: 0x001D86F1
		// (set) Token: 0x06003B6E RID: 15214 RVA: 0x001DA4F9 File Offset: 0x001D86F9
		public StringLiteral ServerName
		{
			get
			{
				return this._serverName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._serverName = value;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06003B6F RID: 15215 RVA: 0x001DA509 File Offset: 0x001D8709
		public IList<AvailabilityReplicaOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x001DA511 File Offset: 0x001D8711
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x001DA520 File Offset: 0x001D8720
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ServerName != null)
			{
				this.ServerName.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400225F RID: 8799
		private StringLiteral _serverName;

		// Token: 0x04002260 RID: 8800
		private List<AvailabilityReplicaOption> _options = new List<AvailabilityReplicaOption>();
	}
}
