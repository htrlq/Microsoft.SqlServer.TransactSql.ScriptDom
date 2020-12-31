using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200027C RID: 636
	[Serializable]
	public class FunctionCallSetClause : SetClause
	{
		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06002D97 RID: 11671 RVA: 0x001CC4A4 File Offset: 0x001CA6A4
		// (set) Token: 0x06002D98 RID: 11672 RVA: 0x001CC4AC File Offset: 0x001CA6AC
		public FunctionCall MutatorFunction
		{
			get
			{
				return this._mutatorFunction;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._mutatorFunction = value;
			}
		}

		// Token: 0x06002D99 RID: 11673 RVA: 0x001CC4BC File Offset: 0x001CA6BC
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D9A RID: 11674 RVA: 0x001CC4C8 File Offset: 0x001CA6C8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.MutatorFunction != null)
			{
				this.MutatorFunction.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E81 RID: 7809
		private FunctionCall _mutatorFunction;
	}
}
