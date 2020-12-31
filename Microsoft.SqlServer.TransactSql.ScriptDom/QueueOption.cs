using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002C2 RID: 706
	[Serializable]
	public class QueueOption : TSqlFragment
	{
		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06002F18 RID: 12056 RVA: 0x001CDD06 File Offset: 0x001CBF06
		// (set) Token: 0x06002F19 RID: 12057 RVA: 0x001CDD0E File Offset: 0x001CBF0E
		public QueueOptionKind OptionKind
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

		// Token: 0x06002F1A RID: 12058 RVA: 0x001CDD17 File Offset: 0x001CBF17
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x001CDD23 File Offset: 0x001CBF23
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EE6 RID: 7910
		private QueueOptionKind _optionKind;
	}
}
