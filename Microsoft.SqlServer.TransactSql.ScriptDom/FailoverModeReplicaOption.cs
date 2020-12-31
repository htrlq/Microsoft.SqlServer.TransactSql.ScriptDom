using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004D4 RID: 1236
	[Serializable]
	public class FailoverModeReplicaOption : AvailabilityReplicaOption
	{
		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06003B81 RID: 15233 RVA: 0x001DA61E File Offset: 0x001D881E
		// (set) Token: 0x06003B82 RID: 15234 RVA: 0x001DA626 File Offset: 0x001D8826
		public FailoverModeOptionKind Value
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

		// Token: 0x06003B83 RID: 15235 RVA: 0x001DA62F File Offset: 0x001D882F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x001DA63B File Offset: 0x001D883B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002264 RID: 8804
		private FailoverModeOptionKind _value;
	}
}
