using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003CF RID: 975
	[Serializable]
	public class ProviderKeyNameKeyOption : KeyOption
	{
		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060035AF RID: 13743 RVA: 0x001D488A File Offset: 0x001D2A8A
		// (set) Token: 0x060035B0 RID: 13744 RVA: 0x001D4892 File Offset: 0x001D2A92
		public Literal KeyName
		{
			get
			{
				return this._keyName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._keyName = value;
			}
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x001D48A2 File Offset: 0x001D2AA2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x001D48AE File Offset: 0x001D2AAE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.KeyName != null)
			{
				this.KeyName.Accept(visitor);
			}
		}

		// Token: 0x040020D2 RID: 8402
		private Literal _keyName;
	}
}
