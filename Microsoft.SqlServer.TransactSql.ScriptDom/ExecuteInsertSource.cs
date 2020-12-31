using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000280 RID: 640
	[Serializable]
	public class ExecuteInsertSource : InsertSource
	{
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06002DA9 RID: 11689 RVA: 0x001CC5BE File Offset: 0x001CA7BE
		// (set) Token: 0x06002DAA RID: 11690 RVA: 0x001CC5C6 File Offset: 0x001CA7C6
		public ExecuteSpecification Execute
		{
			get
			{
				return this._execute;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._execute = value;
			}
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x001CC5D6 File Offset: 0x001CA7D6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x001CC5E2 File Offset: 0x001CA7E2
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Execute != null)
			{
				this.Execute.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E85 RID: 7813
		private ExecuteSpecification _execute;
	}
}
