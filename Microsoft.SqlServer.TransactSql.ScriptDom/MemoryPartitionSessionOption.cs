using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004B1 RID: 1201
	[Serializable]
	public class MemoryPartitionSessionOption : SessionOption
	{
		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06003ABE RID: 15038 RVA: 0x001D99B9 File Offset: 0x001D7BB9
		// (set) Token: 0x06003ABF RID: 15039 RVA: 0x001D99C1 File Offset: 0x001D7BC1
		public EventSessionMemoryPartitionModeType Value
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

		// Token: 0x06003AC0 RID: 15040 RVA: 0x001D99CA File Offset: 0x001D7BCA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x001D99D6 File Offset: 0x001D7BD6
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400222E RID: 8750
		private EventSessionMemoryPartitionModeType _value;
	}
}
