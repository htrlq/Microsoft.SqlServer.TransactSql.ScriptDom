using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004C8 RID: 1224
	[Serializable]
	public class AlterServerConfigurationDiagnosticsLogMaxSizeOption : AlterServerConfigurationDiagnosticsLogOption
	{
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06003B3F RID: 15167 RVA: 0x001DA1B3 File Offset: 0x001D83B3
		// (set) Token: 0x06003B40 RID: 15168 RVA: 0x001DA1BB File Offset: 0x001D83BB
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

		// Token: 0x06003B41 RID: 15169 RVA: 0x001DA1C4 File Offset: 0x001D83C4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x001DA1D0 File Offset: 0x001D83D0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002251 RID: 8785
		private MemoryUnit _sizeUnit;
	}
}
