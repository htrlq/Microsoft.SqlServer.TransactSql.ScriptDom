using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002CB RID: 715
	[Serializable]
	public abstract class QueueStatement : TSqlStatement
	{
		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06002F45 RID: 12101 RVA: 0x001CDFC7 File Offset: 0x001CC1C7
		// (set) Token: 0x06002F46 RID: 12102 RVA: 0x001CDFCF File Offset: 0x001CC1CF
		public SchemaObjectName Name
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

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06002F47 RID: 12103 RVA: 0x001CDFDF File Offset: 0x001CC1DF
		public IList<QueueOption> QueueOptions
		{
			get
			{
				return this._queueOptions;
			}
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x001CDFE8 File Offset: 0x001CC1E8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.QueueOptions.Count;
			while (i < count)
			{
				this.QueueOptions[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EF0 RID: 7920
		private SchemaObjectName _name;

		// Token: 0x04001EF1 RID: 7921
		private List<QueueOption> _queueOptions = new List<QueueOption>();
	}
}
