using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000368 RID: 872
	[Serializable]
	public class IdentifierDatabaseOption : DatabaseOption
	{
		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060032EA RID: 13034 RVA: 0x001D199E File Offset: 0x001CFB9E
		// (set) Token: 0x060032EB RID: 13035 RVA: 0x001D19A6 File Offset: 0x001CFBA6
		public Identifier Value
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

		// Token: 0x060032EC RID: 13036 RVA: 0x001D19B6 File Offset: 0x001CFBB6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x001D19C2 File Offset: 0x001CFBC2
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x04001FF2 RID: 8178
		private Identifier _value;
	}
}
