using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200023D RID: 573
	[Serializable]
	public class OdbcConvertSpecification : ScalarExpression
	{
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x001CA9E6 File Offset: 0x001C8BE6
		// (set) Token: 0x06002C1A RID: 11290 RVA: 0x001CA9EE File Offset: 0x001C8BEE
		public Identifier Identifier
		{
			get
			{
				return this._identifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._identifier = value;
			}
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x001CA9FE File Offset: 0x001C8BFE
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x001CAA0A File Offset: 0x001C8C0A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Identifier != null)
			{
				this.Identifier.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E15 RID: 7701
		private Identifier _identifier;
	}
}
