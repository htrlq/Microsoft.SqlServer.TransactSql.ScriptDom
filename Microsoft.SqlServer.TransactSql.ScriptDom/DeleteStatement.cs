using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000258 RID: 600
	[Serializable]
	public class DeleteStatement : DataModificationStatement
	{
		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06002CA5 RID: 11429 RVA: 0x001CB313 File Offset: 0x001C9513
		// (set) Token: 0x06002CA6 RID: 11430 RVA: 0x001CB31B File Offset: 0x001C951B
		public DeleteSpecification DeleteSpecification
		{
			get
			{
				return this._deleteSpecification;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._deleteSpecification = value;
			}
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x001CB32B File Offset: 0x001C952B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x001CB337 File Offset: 0x001C9537
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.DeleteSpecification != null)
			{
				this.DeleteSpecification.Accept(visitor);
			}
		}

		// Token: 0x04001E35 RID: 7733
		private DeleteSpecification _deleteSpecification;
	}
}
