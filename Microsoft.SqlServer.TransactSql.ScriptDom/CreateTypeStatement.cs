using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002BD RID: 701
	[Serializable]
	public abstract class CreateTypeStatement : TSqlStatement
	{
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06002EFA RID: 12026 RVA: 0x001CDB22 File Offset: 0x001CBD22
		// (set) Token: 0x06002EFB RID: 12027 RVA: 0x001CDB2A File Offset: 0x001CBD2A
		public SchemaObjectName Name
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

		// Token: 0x06002EFC RID: 12028 RVA: 0x001CDB3A File Offset: 0x001CBD3A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EDE RID: 7902
		private SchemaObjectName _name;
	}
}
