using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002AC RID: 684
	[Serializable]
	public class FileTableConstraintNameTableOption : TableOption
	{
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06002E90 RID: 11920 RVA: 0x001CD43D File Offset: 0x001CB63D
		// (set) Token: 0x06002E91 RID: 11921 RVA: 0x001CD445 File Offset: 0x001CB645
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

		// Token: 0x06002E92 RID: 11922 RVA: 0x001CD455 File Offset: 0x001CB655
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x001CD461 File Offset: 0x001CB661
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x04001EBE RID: 7870
		private Identifier _value;
	}
}
