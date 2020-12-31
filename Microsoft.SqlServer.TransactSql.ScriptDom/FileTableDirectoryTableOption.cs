using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002AA RID: 682
	[Serializable]
	public class FileTableDirectoryTableOption : TableOption
	{
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06002E86 RID: 11910 RVA: 0x001CD3AB File Offset: 0x001CB5AB
		// (set) Token: 0x06002E87 RID: 11911 RVA: 0x001CD3B3 File Offset: 0x001CB5B3
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

		// Token: 0x06002E88 RID: 11912 RVA: 0x001CD3C3 File Offset: 0x001CB5C3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x001CD3CF File Offset: 0x001CB5CF
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x04001EBC RID: 7868
		private Literal _value;
	}
}
