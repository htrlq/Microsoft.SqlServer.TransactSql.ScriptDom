using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002B6 RID: 694
	[Serializable]
	public class DropClusteredConstraintValueOption : DropClusteredConstraintOption
	{
		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06002ECB RID: 11979 RVA: 0x001CD7BD File Offset: 0x001CB9BD
		// (set) Token: 0x06002ECC RID: 11980 RVA: 0x001CD7C5 File Offset: 0x001CB9C5
		public Literal OptionValue
		{
			get
			{
				return this._optionValue;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._optionValue = value;
			}
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x001CD7D5 File Offset: 0x001CB9D5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x001CD7E1 File Offset: 0x001CB9E1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.OptionValue != null)
			{
				this.OptionValue.Accept(visitor);
			}
		}

		// Token: 0x04001ECF RID: 7887
		private Literal _optionValue;
	}
}
