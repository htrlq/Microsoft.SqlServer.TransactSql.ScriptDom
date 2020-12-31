using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200043B RID: 1083
	[Serializable]
	public class AlterLoginAddDropCredentialStatement : AlterLoginStatement
	{
		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600382D RID: 14381 RVA: 0x001D71FB File Offset: 0x001D53FB
		// (set) Token: 0x0600382E RID: 14382 RVA: 0x001D7203 File Offset: 0x001D5403
		public bool IsAdd
		{
			get
			{
				return this._isAdd;
			}
			set
			{
				this._isAdd = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600382F RID: 14383 RVA: 0x001D720C File Offset: 0x001D540C
		// (set) Token: 0x06003830 RID: 14384 RVA: 0x001D7214 File Offset: 0x001D5414
		public Identifier CredentialName
		{
			get
			{
				return this._credentialName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._credentialName = value;
			}
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x001D7224 File Offset: 0x001D5424
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x001D7230 File Offset: 0x001D5430
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.CredentialName != null)
			{
				this.CredentialName.Accept(visitor);
			}
		}

		// Token: 0x04002182 RID: 8578
		private bool _isAdd;

		// Token: 0x04002183 RID: 8579
		private Identifier _credentialName;
	}
}
