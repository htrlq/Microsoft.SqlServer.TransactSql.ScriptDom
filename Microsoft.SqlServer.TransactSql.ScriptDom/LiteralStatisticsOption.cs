using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000305 RID: 773
	[Serializable]
	public class LiteralStatisticsOption : StatisticsOption
	{
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x0600309F RID: 12447 RVA: 0x001CF734 File Offset: 0x001CD934
		// (set) Token: 0x060030A0 RID: 12448 RVA: 0x001CF73C File Offset: 0x001CD93C
		public Literal Literal
		{
			get
			{
				return this._literal;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._literal = value;
			}
		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x001CF74C File Offset: 0x001CD94C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x001CF758 File Offset: 0x001CD958
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Literal != null)
			{
				this.Literal.Accept(visitor);
			}
		}

		// Token: 0x04001F54 RID: 8020
		private Literal _literal;
	}
}
