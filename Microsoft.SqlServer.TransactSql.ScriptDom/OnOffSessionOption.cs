using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004B4 RID: 1204
	[Serializable]
	public class OnOffSessionOption : SessionOption
	{
		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06003AD1 RID: 15057 RVA: 0x001D9A80 File Offset: 0x001D7C80
		// (set) Token: 0x06003AD2 RID: 15058 RVA: 0x001D9A88 File Offset: 0x001D7C88
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

		// Token: 0x06003AD3 RID: 15059 RVA: 0x001D9A91 File Offset: 0x001D7C91
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x001D9A9D File Offset: 0x001D7C9D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002233 RID: 8755
		private OptionState _optionState;
	}
}
