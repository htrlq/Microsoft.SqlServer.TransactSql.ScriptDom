using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000367 RID: 871
	[Serializable]
	public class LiteralDatabaseOption : DatabaseOption
	{
		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060032E5 RID: 13029 RVA: 0x001D1955 File Offset: 0x001CFB55
		// (set) Token: 0x060032E6 RID: 13030 RVA: 0x001D195D File Offset: 0x001CFB5D
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

		// Token: 0x060032E7 RID: 13031 RVA: 0x001D196D File Offset: 0x001CFB6D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x001D1979 File Offset: 0x001CFB79
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x04001FF1 RID: 8177
		private Literal _value;
	}
}
