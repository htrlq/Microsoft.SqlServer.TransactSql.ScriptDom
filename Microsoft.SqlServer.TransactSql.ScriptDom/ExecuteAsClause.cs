using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002C1 RID: 705
	[Serializable]
	public class ExecuteAsClause : TSqlFragment
	{
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x001CDCAC File Offset: 0x001CBEAC
		// (set) Token: 0x06002F12 RID: 12050 RVA: 0x001CDCB4 File Offset: 0x001CBEB4
		public ExecuteAsOption ExecuteAsOption
		{
			get
			{
				return this._executeAsOption;
			}
			set
			{
				this._executeAsOption = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x001CDCBD File Offset: 0x001CBEBD
		// (set) Token: 0x06002F14 RID: 12052 RVA: 0x001CDCC5 File Offset: 0x001CBEC5
		public Literal Literal
		{
			get
			{
				return this._literal;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._literal = value;
			}
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x001CDCD5 File Offset: 0x001CBED5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x001CDCE1 File Offset: 0x001CBEE1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Literal != null)
			{
				this.Literal.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EE4 RID: 7908
		private ExecuteAsOption _executeAsOption;

		// Token: 0x04001EE5 RID: 7909
		private Literal _literal;
	}
}
