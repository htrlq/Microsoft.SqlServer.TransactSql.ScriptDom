using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200039D RID: 925
	[Serializable]
	public class OnOffRemoteServiceBindingOption : RemoteServiceBindingOption
	{
		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x001D3463 File Offset: 0x001D1663
		// (set) Token: 0x06003471 RID: 13425 RVA: 0x001D346B File Offset: 0x001D166B
		public OptionState OptionState
		{
			get
			{
				return this._optionState;
			}
			set
			{
				this._optionState = value;
			}
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x001D3474 File Offset: 0x001D1674
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x001D3480 File Offset: 0x001D1680
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002075 RID: 8309
		private OptionState _optionState;
	}
}
