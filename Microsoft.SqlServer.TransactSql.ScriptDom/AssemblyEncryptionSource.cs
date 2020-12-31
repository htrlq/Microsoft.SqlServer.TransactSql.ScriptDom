using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003A2 RID: 930
	[Serializable]
	public class AssemblyEncryptionSource : EncryptionSource
	{
		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06003486 RID: 13446 RVA: 0x001D35C1 File Offset: 0x001D17C1
		// (set) Token: 0x06003487 RID: 13447 RVA: 0x001D35C9 File Offset: 0x001D17C9
		public Identifier Assembly
		{
			get
			{
				return this._assembly;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._assembly = value;
			}
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x001D35D9 File Offset: 0x001D17D9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x001D35E5 File Offset: 0x001D17E5
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Assembly != null)
			{
				this.Assembly.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002079 RID: 8313
		private Identifier _assembly;
	}
}
