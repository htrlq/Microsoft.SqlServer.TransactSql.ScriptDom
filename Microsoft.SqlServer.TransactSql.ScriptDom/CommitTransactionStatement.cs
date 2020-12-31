using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000249 RID: 585
	[Serializable]
	public class CommitTransactionStatement : TransactionStatement
	{
		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x001CAD9F File Offset: 0x001C8F9F
		// (set) Token: 0x06002C55 RID: 11349 RVA: 0x001CADA7 File Offset: 0x001C8FA7
		public OptionState DelayedDurabilityOption
		{
			get
			{
				return this._delayedDurabilityOption;
			}
			set
			{
				this._delayedDurabilityOption = value;
			}
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x001CADB0 File Offset: 0x001C8FB0
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x001CADBC File Offset: 0x001C8FBC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E22 RID: 7714
		private OptionState _delayedDurabilityOption;
	}
}
