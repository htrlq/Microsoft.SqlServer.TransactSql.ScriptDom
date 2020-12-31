using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004C5 RID: 1221
	[Serializable]
	public class AlterServerConfigurationBufferPoolExtensionSizeOption : AlterServerConfigurationBufferPoolExtensionOption
	{
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06003B2F RID: 15151 RVA: 0x001DA0C5 File Offset: 0x001D82C5
		// (set) Token: 0x06003B30 RID: 15152 RVA: 0x001DA0CD File Offset: 0x001D82CD
		public MemoryUnit SizeUnit
		{
			get
			{
				return this._sizeUnit;
			}
			set
			{
				this._sizeUnit = value;
			}
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x001DA0D6 File Offset: 0x001D82D6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x001DA0E2 File Offset: 0x001D82E2
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400224D RID: 8781
		private MemoryUnit _sizeUnit;
	}
}
