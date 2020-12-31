using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200023F RID: 575
	[Serializable]
	public class BeginEndBlockStatement : TSqlStatement
	{
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06002C21 RID: 11297 RVA: 0x001CAB09 File Offset: 0x001C8D09
		// (set) Token: 0x06002C22 RID: 11298 RVA: 0x001CAB11 File Offset: 0x001C8D11
		public StatementList StatementList
		{
			get
			{
				return this._statementList;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._statementList = value;
			}
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x001CAB21 File Offset: 0x001C8D21
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x001CAB2D File Offset: 0x001C8D2D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.StatementList != null)
			{
				this.StatementList.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E16 RID: 7702
		private StatementList _statementList;
	}
}
