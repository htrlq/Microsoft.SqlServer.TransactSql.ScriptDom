using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000436 RID: 1078
	[Serializable]
	public class AsymmetricKeyCreateLoginSource : CreateLoginSource
	{
		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600380C RID: 14348 RVA: 0x001D700E File Offset: 0x001D520E
		// (set) Token: 0x0600380D RID: 14349 RVA: 0x001D7016 File Offset: 0x001D5216
		public Identifier Key
		{
			get
			{
				return this._key;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._key = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600380E RID: 14350 RVA: 0x001D7026 File Offset: 0x001D5226
		// (set) Token: 0x0600380F RID: 14351 RVA: 0x001D702E File Offset: 0x001D522E
		public Identifier Credential
		{
			get
			{
				return this._credential;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._credential = value;
			}
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x001D703E File Offset: 0x001D523E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x001D704A File Offset: 0x001D524A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Key != null)
			{
				this.Key.Accept(visitor);
			}
			if (this.Credential != null)
			{
				this.Credential.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002178 RID: 8568
		private Identifier _key;

		// Token: 0x04002179 RID: 8569
		private Identifier _credential;
	}
}
