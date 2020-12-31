using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200039C RID: 924
	[Serializable]
	public abstract class RemoteServiceBindingOption : TSqlFragment
	{
		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x0600346C RID: 13420 RVA: 0x001D3441 File Offset: 0x001D1641
		// (set) Token: 0x0600346D RID: 13421 RVA: 0x001D3449 File Offset: 0x001D1649
		public RemoteServiceBindingOptionKind OptionKind
		{
			get
			{
				return this._optionKind;
			}
			set
			{
				this._optionKind = value;
			}
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x001D3452 File Offset: 0x001D1652
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002074 RID: 8308
		private RemoteServiceBindingOptionKind _optionKind;
	}
}
