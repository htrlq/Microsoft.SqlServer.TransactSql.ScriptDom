using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200043C RID: 1084
	[Serializable]
	public class RevertStatement : TSqlStatement
	{
		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06003834 RID: 14388 RVA: 0x001D7255 File Offset: 0x001D5455
		// (set) Token: 0x06003835 RID: 14389 RVA: 0x001D725D File Offset: 0x001D545D
		public ScalarExpression Cookie
		{
			get
			{
				return this._cookie;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._cookie = value;
			}
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x001D726D File Offset: 0x001D546D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x001D7279 File Offset: 0x001D5479
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Cookie != null)
			{
				this.Cookie.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002184 RID: 8580
		private ScalarExpression _cookie;
	}
}
