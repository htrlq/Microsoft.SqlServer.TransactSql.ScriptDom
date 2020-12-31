using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003CC RID: 972
	[Serializable]
	public class KeySourceKeyOption : KeyOption
	{
		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060035A0 RID: 13728 RVA: 0x001D47CA File Offset: 0x001D29CA
		// (set) Token: 0x060035A1 RID: 13729 RVA: 0x001D47D2 File Offset: 0x001D29D2
		public Literal PassPhrase
		{
			get
			{
				return this._passPhrase;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._passPhrase = value;
			}
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x001D47E2 File Offset: 0x001D29E2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x001D47EE File Offset: 0x001D29EE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.PassPhrase != null)
			{
				this.PassPhrase.Accept(visitor);
			}
		}

		// Token: 0x040020CF RID: 8399
		private Literal _passPhrase;
	}
}
