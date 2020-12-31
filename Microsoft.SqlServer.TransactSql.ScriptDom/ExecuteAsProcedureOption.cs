using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001E4 RID: 484
	[Serializable]
	public class ExecuteAsProcedureOption : ProcedureOption
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060029EE RID: 10734 RVA: 0x001C8153 File Offset: 0x001C6353
		// (set) Token: 0x060029EF RID: 10735 RVA: 0x001C815B File Offset: 0x001C635B
		public ExecuteAsClause ExecuteAs
		{
			get
			{
				return this._executeAs;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._executeAs = value;
			}
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x001C816B File Offset: 0x001C636B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x001C8177 File Offset: 0x001C6377
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.ExecuteAs != null)
			{
				this.ExecuteAs.Accept(visitor);
			}
		}

		// Token: 0x04001D6D RID: 7533
		private ExecuteAsClause _executeAs;
	}
}
