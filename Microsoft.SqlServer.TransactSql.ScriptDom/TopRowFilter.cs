using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000406 RID: 1030
	[Serializable]
	public class TopRowFilter : TSqlFragment
	{
		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600370A RID: 14090 RVA: 0x001D6198 File Offset: 0x001D4398
		// (set) Token: 0x0600370B RID: 14091 RVA: 0x001D61A0 File Offset: 0x001D43A0
		public ScalarExpression Expression
		{
			get
			{
				return this._expression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._expression = value;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x0600370C RID: 14092 RVA: 0x001D61B0 File Offset: 0x001D43B0
		// (set) Token: 0x0600370D RID: 14093 RVA: 0x001D61B8 File Offset: 0x001D43B8
		public bool Percent
		{
			get
			{
				return this._percent;
			}
			set
			{
				this._percent = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600370E RID: 14094 RVA: 0x001D61C1 File Offset: 0x001D43C1
		// (set) Token: 0x0600370F RID: 14095 RVA: 0x001D61C9 File Offset: 0x001D43C9
		public bool WithTies
		{
			get
			{
				return this._withTies;
			}
			set
			{
				this._withTies = value;
			}
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x001D61D2 File Offset: 0x001D43D2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x001D61DE File Offset: 0x001D43DE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400213B RID: 8507
		private ScalarExpression _expression;

		// Token: 0x0400213C RID: 8508
		private bool _percent;

		// Token: 0x0400213D RID: 8509
		private bool _withTies;
	}
}
