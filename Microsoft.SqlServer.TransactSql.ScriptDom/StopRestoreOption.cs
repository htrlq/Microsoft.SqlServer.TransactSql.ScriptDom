using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000386 RID: 902
	[Serializable]
	public class StopRestoreOption : RestoreOption
	{
		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060033D2 RID: 13266 RVA: 0x001D29BA File Offset: 0x001D0BBA
		// (set) Token: 0x060033D3 RID: 13267 RVA: 0x001D29C2 File Offset: 0x001D0BC2
		public ValueExpression Mark
		{
			get
			{
				return this._mark;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._mark = value;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x060033D4 RID: 13268 RVA: 0x001D29D2 File Offset: 0x001D0BD2
		// (set) Token: 0x060033D5 RID: 13269 RVA: 0x001D29DA File Offset: 0x001D0BDA
		public ValueExpression After
		{
			get
			{
				return this._after;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._after = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060033D6 RID: 13270 RVA: 0x001D29EA File Offset: 0x001D0BEA
		// (set) Token: 0x060033D7 RID: 13271 RVA: 0x001D29F2 File Offset: 0x001D0BF2
		public bool IsStopAt
		{
			get
			{
				return this._isStopAt;
			}
			set
			{
				this._isStopAt = value;
			}
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x001D29FB File Offset: 0x001D0BFB
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x001D2A07 File Offset: 0x001D0C07
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Mark != null)
			{
				this.Mark.Accept(visitor);
			}
			if (this.After != null)
			{
				this.After.Accept(visitor);
			}
		}

		// Token: 0x04002042 RID: 8258
		private ValueExpression _mark;

		// Token: 0x04002043 RID: 8259
		private ValueExpression _after;

		// Token: 0x04002044 RID: 8260
		private bool _isStopAt;
	}
}
