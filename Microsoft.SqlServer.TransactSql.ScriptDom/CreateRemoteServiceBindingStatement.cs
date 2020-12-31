using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200039F RID: 927
	[Serializable]
	public class CreateRemoteServiceBindingStatement : RemoteServiceBindingStatementBase, IAuthorization
	{
		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x0600347A RID: 13434 RVA: 0x001D34DA File Offset: 0x001D16DA
		// (set) Token: 0x0600347B RID: 13435 RVA: 0x001D34E2 File Offset: 0x001D16E2
		public Literal Service
		{
			get
			{
				return this._service;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._service = value;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x0600347C RID: 13436 RVA: 0x001D34F2 File Offset: 0x001D16F2
		// (set) Token: 0x0600347D RID: 13437 RVA: 0x001D34FA File Offset: 0x001D16FA
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

		// Token: 0x0600347E RID: 13438 RVA: 0x001D350A File Offset: 0x001D170A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x001D3518 File Offset: 0x001D1718
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			if (this.Service != null)
			{
				this.Service.Accept(visitor);
			}
			int i = 0;
			int count = base.Options.Count;
			while (i < count)
			{
				base.Options[i].Accept(visitor);
				i++;
			}
			if (this.Owner != null)
			{
				this.Owner.Accept(visitor);
			}
		}

		// Token: 0x04002077 RID: 8311
		private Literal _service;

		// Token: 0x04002078 RID: 8312
		private Identifier _owner;
	}
}
