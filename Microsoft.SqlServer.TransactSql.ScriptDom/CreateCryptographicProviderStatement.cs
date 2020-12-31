using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004A4 RID: 1188
	[Serializable]
	public class CreateCryptographicProviderStatement : TSqlStatement
	{
		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06003A6E RID: 14958 RVA: 0x001D93E1 File Offset: 0x001D75E1
		// (set) Token: 0x06003A6F RID: 14959 RVA: 0x001D93E9 File Offset: 0x001D75E9
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

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06003A70 RID: 14960 RVA: 0x001D93F9 File Offset: 0x001D75F9
		// (set) Token: 0x06003A71 RID: 14961 RVA: 0x001D9401 File Offset: 0x001D7601
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

		// Token: 0x06003A72 RID: 14962 RVA: 0x001D9411 File Offset: 0x001D7611
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A73 RID: 14963 RVA: 0x001D941D File Offset: 0x001D761D
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

		// Token: 0x04002216 RID: 8726
		private Identifier _name;

		// Token: 0x04002217 RID: 8727
		private Literal _file;
	}
}
