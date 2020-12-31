using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000440 RID: 1088
	[Serializable]
	public class DropQueueStatement : TSqlStatement
	{
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06003842 RID: 14402 RVA: 0x001D72F5 File Offset: 0x001D54F5
		// (set) Token: 0x06003843 RID: 14403 RVA: 0x001D72FD File Offset: 0x001D54FD
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

		// Token: 0x06003844 RID: 14404 RVA: 0x001D730D File Offset: 0x001D550D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x001D7319 File Offset: 0x001D5519
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002185 RID: 8581
		private SchemaObjectName _name;
	}
}
