using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000432 RID: 1074
	[Serializable]
	public class LiteralPrincipalOption : PrincipalOption
	{
		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060037F7 RID: 14327 RVA: 0x001D6EA1 File Offset: 0x001D50A1
		// (set) Token: 0x060037F8 RID: 14328 RVA: 0x001D6EA9 File Offset: 0x001D50A9
		public Literal Value
		{
			get
			{
				return this._value;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._value = value;
			}
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x001D6EB9 File Offset: 0x001D50B9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x001D6EC5 File Offset: 0x001D50C5
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x04002173 RID: 8563
		private Literal _value;
	}
}
