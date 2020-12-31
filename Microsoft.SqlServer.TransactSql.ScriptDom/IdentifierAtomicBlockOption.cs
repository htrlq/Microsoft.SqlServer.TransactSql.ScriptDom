using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000243 RID: 579
	[Serializable]
	public class IdentifierAtomicBlockOption : AtomicBlockOption
	{
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06002C33 RID: 11315 RVA: 0x001CAC24 File Offset: 0x001C8E24
		// (set) Token: 0x06002C34 RID: 11316 RVA: 0x001CAC2C File Offset: 0x001C8E2C
		public Identifier Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x001CAC35 File Offset: 0x001C8E35
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x001CAC41 File Offset: 0x001C8E41
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E1A RID: 7706
		private Identifier _value;
	}
}
