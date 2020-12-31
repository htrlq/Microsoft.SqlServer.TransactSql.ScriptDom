using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003CE RID: 974
	[Serializable]
	public class IdentityValueKeyOption : KeyOption
	{
		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060035AA RID: 13738 RVA: 0x001D4841 File Offset: 0x001D2A41
		// (set) Token: 0x060035AB RID: 13739 RVA: 0x001D4849 File Offset: 0x001D2A49
		public Literal IdentityPhrase
		{
			get
			{
				return this._identityPhrase;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._identityPhrase = value;
			}
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x001D4859 File Offset: 0x001D2A59
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060035AD RID: 13741 RVA: 0x001D4865 File Offset: 0x001D2A65
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.IdentityPhrase != null)
			{
				this.IdentityPhrase.Accept(visitor);
			}
		}

		// Token: 0x040020D1 RID: 8401
		private Literal _identityPhrase;
	}
}
