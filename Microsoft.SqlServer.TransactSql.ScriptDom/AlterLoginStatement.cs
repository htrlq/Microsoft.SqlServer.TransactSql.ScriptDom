using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000438 RID: 1080
	[Serializable]
	public abstract class AlterLoginStatement : TSqlStatement
	{
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06003820 RID: 14368 RVA: 0x001D712B File Offset: 0x001D532B
		// (set) Token: 0x06003821 RID: 14369 RVA: 0x001D7133 File Offset: 0x001D5333
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x001D7143 File Offset: 0x001D5343
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400217F RID: 8575
		private Identifier _name;
	}
}
