using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002B7 RID: 695
	[Serializable]
	public class DropClusteredConstraintMoveOption : DropClusteredConstraintOption
	{
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06002ED0 RID: 11984 RVA: 0x001CD806 File Offset: 0x001CBA06
		// (set) Token: 0x06002ED1 RID: 11985 RVA: 0x001CD80E File Offset: 0x001CBA0E
		public FileGroupOrPartitionScheme OptionValue
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

		// Token: 0x06002ED2 RID: 11986 RVA: 0x001CD81E File Offset: 0x001CBA1E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x001CD82A File Offset: 0x001CBA2A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.OptionValue != null)
			{
				this.OptionValue.Accept(visitor);
			}
		}

		// Token: 0x04001ED0 RID: 7888
		private FileGroupOrPartitionScheme _optionValue;
	}
}
