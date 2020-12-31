using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001C3 RID: 451
	[Serializable]
	public class ExecuteOption : TSqlFragment
	{
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06002920 RID: 10528 RVA: 0x001C725D File Offset: 0x001C545D
		// (set) Token: 0x06002921 RID: 10529 RVA: 0x001C7265 File Offset: 0x001C5465
		public ExecuteOptionKind OptionKind
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

		// Token: 0x06002922 RID: 10530 RVA: 0x001C726E File Offset: 0x001C546E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x001C727A File Offset: 0x001C547A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D2F RID: 7471
		private ExecuteOptionKind _optionKind;
	}
}
