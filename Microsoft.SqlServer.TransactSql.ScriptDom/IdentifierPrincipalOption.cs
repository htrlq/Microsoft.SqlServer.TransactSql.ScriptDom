using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000433 RID: 1075
	[Serializable]
	public class IdentifierPrincipalOption : PrincipalOption
	{
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060037FC RID: 14332 RVA: 0x001D6EEA File Offset: 0x001D50EA
		// (set) Token: 0x060037FD RID: 14333 RVA: 0x001D6EF2 File Offset: 0x001D50F2
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

		// Token: 0x060037FE RID: 14334 RVA: 0x001D6F02 File Offset: 0x001D5102
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x001D6F0E File Offset: 0x001D510E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Identifier != null)
			{
				this.Identifier.Accept(visitor);
			}
		}

		// Token: 0x04002174 RID: 8564
		private Identifier _identifier;
	}
}
