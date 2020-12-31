using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004A5 RID: 1189
	[Serializable]
	public class AlterCryptographicProviderStatement : TSqlStatement
	{
		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06003A75 RID: 14965 RVA: 0x001D9456 File Offset: 0x001D7656
		// (set) Token: 0x06003A76 RID: 14966 RVA: 0x001D945E File Offset: 0x001D765E
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

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06003A77 RID: 14967 RVA: 0x001D946E File Offset: 0x001D766E
		// (set) Token: 0x06003A78 RID: 14968 RVA: 0x001D9476 File Offset: 0x001D7676
		public EnableDisableOptionType Option
		{
			get
			{
				return this._option;
			}
			set
			{
				this._option = value;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06003A79 RID: 14969 RVA: 0x001D947F File Offset: 0x001D767F
		// (set) Token: 0x06003A7A RID: 14970 RVA: 0x001D9487 File Offset: 0x001D7687
		public Literal File
		{
			get
			{
				return this._file;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._file = value;
			}
		}

		// Token: 0x06003A7B RID: 14971 RVA: 0x001D9497 File Offset: 0x001D7697
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x001D94A3 File Offset: 0x001D76A3
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.File != null)
			{
				this.File.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002218 RID: 8728
		private Identifier _name;

		// Token: 0x04002219 RID: 8729
		private EnableDisableOptionType _option;

		// Token: 0x0400221A RID: 8730
		private Literal _file;
	}
}
