using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002D0 RID: 720
	[Serializable]
	public class IndexType : TSqlFragment
	{
		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06002F66 RID: 12134 RVA: 0x001CE2E1 File Offset: 0x001CC4E1
		// (set) Token: 0x06002F67 RID: 12135 RVA: 0x001CE2E9 File Offset: 0x001CC4E9
		public IndexTypeKind? IndexTypeKind
		{
			get
			{
				return this._indexTypeKind;
			}
			set
			{
				this._indexTypeKind = value;
			}
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x001CE2F2 File Offset: 0x001CC4F2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x001CE2FE File Offset: 0x001CC4FE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EFC RID: 7932
		private IndexTypeKind? _indexTypeKind;
	}
}
