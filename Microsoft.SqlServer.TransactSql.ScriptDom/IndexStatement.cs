using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002CF RID: 719
	[Serializable]
	public abstract class IndexStatement : TSqlStatement
	{
		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x001CE22E File Offset: 0x001CC42E
		// (set) Token: 0x06002F60 RID: 12128 RVA: 0x001CE236 File Offset: 0x001CC436
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

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06002F61 RID: 12129 RVA: 0x001CE246 File Offset: 0x001CC446
		// (set) Token: 0x06002F62 RID: 12130 RVA: 0x001CE24E File Offset: 0x001CC44E
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

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06002F63 RID: 12131 RVA: 0x001CE25E File Offset: 0x001CC45E
		public IList<IndexOption> IndexOptions
		{
			get
			{
				return this._indexOptions;
			}
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x001CE268 File Offset: 0x001CC468
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
			int count = this.IndexOptions.Count;
			while (i < count)
			{
				this.IndexOptions[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EF9 RID: 7929
		private Identifier _name;

		// Token: 0x04001EFA RID: 7930
		private SchemaObjectName _onName;

		// Token: 0x04001EFB RID: 7931
		private List<IndexOption> _indexOptions = new List<IndexOption>();
	}
}
