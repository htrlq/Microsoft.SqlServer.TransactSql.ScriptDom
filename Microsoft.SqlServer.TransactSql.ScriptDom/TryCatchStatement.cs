using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002BC RID: 700
	[Serializable]
	public class TryCatchStatement : TSqlStatement
	{
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x001CDAAD File Offset: 0x001CBCAD
		// (set) Token: 0x06002EF4 RID: 12020 RVA: 0x001CDAB5 File Offset: 0x001CBCB5
		public StatementList TryStatements
		{
			get
			{
				return this._tryStatements;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._tryStatements = value;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06002EF5 RID: 12021 RVA: 0x001CDAC5 File Offset: 0x001CBCC5
		// (set) Token: 0x06002EF6 RID: 12022 RVA: 0x001CDACD File Offset: 0x001CBCCD
		public StatementList CatchStatements
		{
			get
			{
				return this._catchStatements;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._catchStatements = value;
			}
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x001CDADD File Offset: 0x001CBCDD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x001CDAE9 File Offset: 0x001CBCE9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.TryStatements != null)
			{
				this.TryStatements.Accept(visitor);
			}
			if (this.CatchStatements != null)
			{
				this.CatchStatements.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EDC RID: 7900
		private StatementList _tryStatements;

		// Token: 0x04001EDD RID: 7901
		private StatementList _catchStatements;
	}
}
