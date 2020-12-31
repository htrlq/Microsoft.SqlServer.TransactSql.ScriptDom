using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003C2 RID: 962
	[Serializable]
	public class LiteralPayloadOption : PayloadOption
	{
		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06003562 RID: 13666 RVA: 0x001D4442 File Offset: 0x001D2642
		// (set) Token: 0x06003563 RID: 13667 RVA: 0x001D444A File Offset: 0x001D264A
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

		// Token: 0x06003564 RID: 13668 RVA: 0x001D445A File Offset: 0x001D265A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x001D4466 File Offset: 0x001D2666
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x040020BD RID: 8381
		private Literal _value;
	}
}
