using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000464 RID: 1124
	[Serializable]
	public class IdentifierSnippet : Identifier
	{
		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06003923 RID: 14627 RVA: 0x001D8038 File Offset: 0x001D6238
		// (set) Token: 0x06003924 RID: 14628 RVA: 0x001D8040 File Offset: 0x001D6240
		public string Script
		{
			get
			{
				return this._script;
			}
			set
			{
				this._script = value;
			}
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x001D8049 File Offset: 0x001D6249
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x001D8055 File Offset: 0x001D6255
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021C4 RID: 8644
		private string _script;
	}
}
