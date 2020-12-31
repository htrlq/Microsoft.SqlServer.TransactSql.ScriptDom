using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001FE RID: 510
	[Serializable]
	public class TableHint : TSqlFragment
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06002A6F RID: 10863 RVA: 0x001C8A71 File Offset: 0x001C6C71
		// (set) Token: 0x06002A70 RID: 10864 RVA: 0x001C8A79 File Offset: 0x001C6C79
		public TableHintKind HintKind
		{
			get
			{
				return this._hintKind;
			}
			set
			{
				this._hintKind = value;
			}
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x001C8A82 File Offset: 0x001C6C82
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x001C8A8E File Offset: 0x001C6C8E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D8F RID: 7567
		private TableHintKind _hintKind;
	}
}
