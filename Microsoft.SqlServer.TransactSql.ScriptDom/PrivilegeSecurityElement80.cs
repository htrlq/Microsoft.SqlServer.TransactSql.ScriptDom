using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000276 RID: 630
	[Serializable]
	public class PrivilegeSecurityElement80 : SecurityElement80
	{
		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06002D74 RID: 11636 RVA: 0x001CC1FC File Offset: 0x001CA3FC
		public IList<Privilege80> Privileges
		{
			get
			{
				return this._privileges;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x001CC204 File Offset: 0x001CA404
		// (set) Token: 0x06002D76 RID: 11638 RVA: 0x001CC20C File Offset: 0x001CA40C
		public SchemaObjectName SchemaObjectName
		{
			get
			{
				return this._schemaObjectName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._schemaObjectName = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06002D77 RID: 11639 RVA: 0x001CC21C File Offset: 0x001CA41C
		public IList<Identifier> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x001CC224 File Offset: 0x001CA424
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x001CC230 File Offset: 0x001CA430
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Privileges.Count;
			while (i < count)
			{
				this.Privileges[i].Accept(visitor);
				i++;
			}
			if (this.SchemaObjectName != null)
			{
				this.SchemaObjectName.Accept(visitor);
			}
			int j = 0;
			int count2 = this.Columns.Count;
			while (j < count2)
			{
				this.Columns[j].Accept(visitor);
				j++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E76 RID: 7798
		private List<Privilege80> _privileges = new List<Privilege80>();

		// Token: 0x04001E77 RID: 7799
		private SchemaObjectName _schemaObjectName;

		// Token: 0x04001E78 RID: 7800
		private List<Identifier> _columns = new List<Identifier>();
	}
}
