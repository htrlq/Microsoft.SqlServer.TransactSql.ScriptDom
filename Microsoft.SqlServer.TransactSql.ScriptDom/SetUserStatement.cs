using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000335 RID: 821
	[Serializable]
	public class SetUserStatement : TSqlStatement
	{
		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x001D0877 File Offset: 0x001CEA77
		// (set) Token: 0x060031AF RID: 12719 RVA: 0x001D087F File Offset: 0x001CEA7F
		public ValueExpression UserName
		{
			get
			{
				return this._userName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._userName = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060031B0 RID: 12720 RVA: 0x001D088F File Offset: 0x001CEA8F
		// (set) Token: 0x060031B1 RID: 12721 RVA: 0x001D0897 File Offset: 0x001CEA97
		public bool WithNoReset
		{
			get
			{
				return this._withNoReset;
			}
			set
			{
				this._withNoReset = value;
			}
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x001D08A0 File Offset: 0x001CEAA0
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x001D08AC File Offset: 0x001CEAAC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.UserName != null)
			{
				this.UserName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F9B RID: 8091
		private ValueExpression _userName;

		// Token: 0x04001F9C RID: 8092
		private bool _withNoReset;
	}
}
