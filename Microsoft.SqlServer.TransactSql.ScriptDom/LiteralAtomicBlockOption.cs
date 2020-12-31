using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000242 RID: 578
	[Serializable]
	public class LiteralAtomicBlockOption : AtomicBlockOption
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06002C2E RID: 11310 RVA: 0x001CABDB File Offset: 0x001C8DDB
		// (set) Token: 0x06002C2F RID: 11311 RVA: 0x001CABE3 File Offset: 0x001C8DE3
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

		// Token: 0x06002C30 RID: 11312 RVA: 0x001CABF3 File Offset: 0x001C8DF3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x001CABFF File Offset: 0x001C8DFF
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x04001E19 RID: 7705
		private Literal _value;
	}
}
