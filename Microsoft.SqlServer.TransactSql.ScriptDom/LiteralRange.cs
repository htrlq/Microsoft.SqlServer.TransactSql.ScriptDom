using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000285 RID: 645
	[Serializable]
	public class LiteralRange : TSqlFragment
	{
		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x001CC774 File Offset: 0x001CA974
		// (set) Token: 0x06002DC4 RID: 11716 RVA: 0x001CC77C File Offset: 0x001CA97C
		public Literal From
		{
			get
			{
				return this._from;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._from = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x001CC78C File Offset: 0x001CA98C
		// (set) Token: 0x06002DC6 RID: 11718 RVA: 0x001CC794 File Offset: 0x001CA994
		public Literal To
		{
			get
			{
				return this._to;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._to = value;
			}
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x001CC7A4 File Offset: 0x001CA9A4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x001CC7B0 File Offset: 0x001CA9B0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.From != null)
			{
				this.From.Accept(visitor);
			}
			if (this.To != null)
			{
				this.To.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E8B RID: 7819
		private Literal _from;

		// Token: 0x04001E8C RID: 7820
		private Literal _to;
	}
}
