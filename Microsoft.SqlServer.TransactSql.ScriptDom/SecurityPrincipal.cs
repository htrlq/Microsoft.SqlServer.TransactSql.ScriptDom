using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200026F RID: 623
	[Serializable]
	public class SecurityPrincipal : TSqlFragment
	{
		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06002D49 RID: 11593 RVA: 0x001CBFF6 File Offset: 0x001CA1F6
		// (set) Token: 0x06002D4A RID: 11594 RVA: 0x001CBFFE File Offset: 0x001CA1FE
		public PrincipalType PrincipalType
		{
			get
			{
				return this._principalType;
			}
			set
			{
				this._principalType = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06002D4B RID: 11595 RVA: 0x001CC007 File Offset: 0x001CA207
		// (set) Token: 0x06002D4C RID: 11596 RVA: 0x001CC00F File Offset: 0x001CA20F
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

		// Token: 0x06002D4D RID: 11597 RVA: 0x001CC01F File Offset: 0x001CA21F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x001CC02B File Offset: 0x001CA22B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Identifier != null)
			{
				this.Identifier.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E6A RID: 7786
		private PrincipalType _principalType;

		// Token: 0x04001E6B RID: 7787
		private Identifier _identifier;
	}
}
