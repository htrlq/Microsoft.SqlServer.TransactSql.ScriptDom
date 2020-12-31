using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000245 RID: 581
	[Serializable]
	public abstract class TransactionStatement : TSqlStatement
	{
		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x001CAC80 File Offset: 0x001C8E80
		// (set) Token: 0x06002C3E RID: 11326 RVA: 0x001CAC88 File Offset: 0x001C8E88
		public IdentifierOrValueExpression Name
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

		// Token: 0x06002C3F RID: 11327 RVA: 0x001CAC98 File Offset: 0x001C8E98
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E1C RID: 7708
		private IdentifierOrValueExpression _name;
	}
}
