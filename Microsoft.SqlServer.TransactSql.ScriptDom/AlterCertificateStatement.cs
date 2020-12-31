using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003A6 RID: 934
	[Serializable]
	public class AlterCertificateStatement : CertificateStatementBase
	{
		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060034A4 RID: 13476 RVA: 0x001D37D4 File Offset: 0x001D19D4
		// (set) Token: 0x060034A5 RID: 13477 RVA: 0x001D37DC File Offset: 0x001D19DC
		public AlterCertificateStatementKind Kind
		{
			get
			{
				return this._kind;
			}
			set
			{
				this._kind = value;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060034A6 RID: 13478 RVA: 0x001D37E5 File Offset: 0x001D19E5
		// (set) Token: 0x060034A7 RID: 13479 RVA: 0x001D37ED File Offset: 0x001D19ED
		public Literal AttestedBy
		{
			get
			{
				return this._attestedBy;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._attestedBy = value;
			}
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x001D37FD File Offset: 0x001D19FD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x001D3809 File Offset: 0x001D1A09
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.AttestedBy != null)
			{
				this.AttestedBy.Accept(visitor);
			}
		}

		// Token: 0x04002083 RID: 8323
		private AlterCertificateStatementKind _kind;

		// Token: 0x04002084 RID: 8324
		private Literal _attestedBy;
	}
}
