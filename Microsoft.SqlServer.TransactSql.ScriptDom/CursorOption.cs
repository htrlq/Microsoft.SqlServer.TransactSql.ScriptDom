using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200030B RID: 779
	[Serializable]
	public class CursorOption : TSqlFragment
	{
		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060030C8 RID: 12488 RVA: 0x001CFAC5 File Offset: 0x001CDCC5
		// (set) Token: 0x060030C9 RID: 12489 RVA: 0x001CFACD File Offset: 0x001CDCCD
		public CursorOptionKind OptionKind
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

		// Token: 0x060030CA RID: 12490 RVA: 0x001CFAD6 File Offset: 0x001CDCD6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x001CFAE2 File Offset: 0x001CDCE2
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F62 RID: 8034
		private CursorOptionKind _optionKind;
	}
}
