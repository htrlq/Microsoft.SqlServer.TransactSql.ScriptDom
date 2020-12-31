using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200038D RID: 909
	[Serializable]
	public abstract class BulkInsertBase : TSqlStatement
	{
		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06003401 RID: 13313 RVA: 0x001D2C85 File Offset: 0x001D0E85
		// (set) Token: 0x06003402 RID: 13314 RVA: 0x001D2C8D File Offset: 0x001D0E8D
		public SchemaObjectName To
		{
			get
			{
				return this._to;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._to = value;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06003403 RID: 13315 RVA: 0x001D2C9D File Offset: 0x001D0E9D
		public IList<BulkInsertOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x001D2CA8 File Offset: 0x001D0EA8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.To != null)
			{
				this.To.Accept(visitor);
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

		// Token: 0x04002050 RID: 8272
		private SchemaObjectName _to;

		// Token: 0x04002051 RID: 8273
		private List<BulkInsertOption> _options = new List<BulkInsertOption>();
	}
}
