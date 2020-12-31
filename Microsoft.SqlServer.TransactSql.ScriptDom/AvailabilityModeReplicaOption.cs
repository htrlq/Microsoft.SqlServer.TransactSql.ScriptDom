using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004D3 RID: 1235
	[Serializable]
	public class AvailabilityModeReplicaOption : AvailabilityReplicaOption
	{
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06003B7C RID: 15228 RVA: 0x001DA5F0 File Offset: 0x001D87F0
		// (set) Token: 0x06003B7D RID: 15229 RVA: 0x001DA5F8 File Offset: 0x001D87F8
		public AvailabilityModeOptionKind Value
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

		// Token: 0x06003B7E RID: 15230 RVA: 0x001DA601 File Offset: 0x001D8801
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x001DA60D File Offset: 0x001D880D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002263 RID: 8803
		private AvailabilityModeOptionKind _value;
	}
}
