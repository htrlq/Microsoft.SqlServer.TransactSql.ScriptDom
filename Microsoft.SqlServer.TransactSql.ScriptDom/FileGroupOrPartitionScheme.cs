using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002D5 RID: 725
	[Serializable]
	public class FileGroupOrPartitionScheme : TSqlFragment
	{
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06002F97 RID: 12183 RVA: 0x001CE6F4 File Offset: 0x001CC8F4
		// (set) Token: 0x06002F98 RID: 12184 RVA: 0x001CE6FC File Offset: 0x001CC8FC
		public IdentifierOrValueExpression Name
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

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06002F99 RID: 12185 RVA: 0x001CE70C File Offset: 0x001CC90C
		public IList<Identifier> PartitionSchemeColumns
		{
			get
			{
				return this._partitionSchemeColumns;
			}
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x001CE714 File Offset: 0x001CC914
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x001CE720 File Offset: 0x001CC920
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.PartitionSchemeColumns.Count;
			while (i < count)
			{
				this.PartitionSchemeColumns[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F0E RID: 7950
		private IdentifierOrValueExpression _name;

		// Token: 0x04001F0F RID: 7951
		private List<Identifier> _partitionSchemeColumns = new List<Identifier>();
	}
}
