using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000457 RID: 1111
	[Serializable]
	public class BackupCertificateStatement : CertificateStatementBase
	{
		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060038E3 RID: 14563 RVA: 0x001D7D82 File Offset: 0x001D5F82
		// (set) Token: 0x060038E4 RID: 14564 RVA: 0x001D7D8A File Offset: 0x001D5F8A
		public Literal File
		{
			get
			{
				return this._file;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._file = value;
			}
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x001D7D9A File Offset: 0x001D5F9A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x001D7DA6 File Offset: 0x001D5FA6
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.File != null)
			{
				this.File.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021B7 RID: 8631
		private Literal _file;
	}
}
