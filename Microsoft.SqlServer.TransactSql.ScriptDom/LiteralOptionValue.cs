using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000289 RID: 649
	[Serializable]
	public class LiteralOptionValue : OptionValue
	{
		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06002DD6 RID: 11734 RVA: 0x001CC856 File Offset: 0x001CAA56
		// (set) Token: 0x06002DD7 RID: 11735 RVA: 0x001CC85E File Offset: 0x001CAA5E
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

		// Token: 0x06002DD8 RID: 11736 RVA: 0x001CC86E File Offset: 0x001CAA6E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x001CC87A File Offset: 0x001CAA7A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x04001E8F RID: 7823
		private Literal _value;
	}
}
