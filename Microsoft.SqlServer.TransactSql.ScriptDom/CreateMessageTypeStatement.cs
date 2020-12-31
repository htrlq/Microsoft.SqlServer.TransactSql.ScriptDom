using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003AF RID: 943
	[Serializable]
	public class CreateMessageTypeStatement : MessageTypeStatementBase, IAuthorization
	{
		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060034E1 RID: 13537 RVA: 0x001D3C28 File Offset: 0x001D1E28
		// (set) Token: 0x060034E2 RID: 13538 RVA: 0x001D3C30 File Offset: 0x001D1E30
		public Identifier Owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._owner = value;
			}
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x001D3C40 File Offset: 0x001D1E40
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x001D3C4C File Offset: 0x001D1E4C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			if (base.XmlSchemaCollectionName != null)
			{
				base.XmlSchemaCollectionName.Accept(visitor);
			}
			if (this.Owner != null)
			{
				this.Owner.Accept(visitor);
			}
		}

		// Token: 0x04002096 RID: 8342
		private Identifier _owner;
	}
}
