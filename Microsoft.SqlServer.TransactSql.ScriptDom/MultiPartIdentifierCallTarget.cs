using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000233 RID: 563
	[Serializable]
	public class MultiPartIdentifierCallTarget : CallTarget
	{
		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06002BDE RID: 11230 RVA: 0x001CA573 File Offset: 0x001C8773
		// (set) Token: 0x06002BDF RID: 11231 RVA: 0x001CA57B File Offset: 0x001C877B
		public MultiPartIdentifier MultiPartIdentifier
		{
			get
			{
				return this._multiPartIdentifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._multiPartIdentifier = value;
			}
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x001CA58B File Offset: 0x001C878B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x001CA597 File Offset: 0x001C8797
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.MultiPartIdentifier != null)
			{
				this.MultiPartIdentifier.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E04 RID: 7684
		private MultiPartIdentifier _multiPartIdentifier;
	}
}
