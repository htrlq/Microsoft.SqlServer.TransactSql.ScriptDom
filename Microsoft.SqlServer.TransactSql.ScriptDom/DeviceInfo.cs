using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200038A RID: 906
	[Serializable]
	public class DeviceInfo : TSqlFragment
	{
		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060033EE RID: 13294 RVA: 0x001D2B22 File Offset: 0x001D0D22
		// (set) Token: 0x060033EF RID: 13295 RVA: 0x001D2B2A File Offset: 0x001D0D2A
		public IdentifierOrValueExpression LogicalDevice
		{
			get
			{
				return this._logicalDevice;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._logicalDevice = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060033F0 RID: 13296 RVA: 0x001D2B3A File Offset: 0x001D0D3A
		// (set) Token: 0x060033F1 RID: 13297 RVA: 0x001D2B42 File Offset: 0x001D0D42
		public ValueExpression PhysicalDevice
		{
			get
			{
				return this._physicalDevice;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._physicalDevice = value;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060033F2 RID: 13298 RVA: 0x001D2B52 File Offset: 0x001D0D52
		// (set) Token: 0x060033F3 RID: 13299 RVA: 0x001D2B5A File Offset: 0x001D0D5A
		public DeviceType DeviceType
		{
			get
			{
				return this._deviceType;
			}
			set
			{
				this._deviceType = value;
			}
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x001D2B63 File Offset: 0x001D0D63
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x001D2B6F File Offset: 0x001D0D6F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.LogicalDevice != null)
			{
				this.LogicalDevice.Accept(visitor);
			}
			if (this.PhysicalDevice != null)
			{
				this.PhysicalDevice.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400204A RID: 8266
		private IdentifierOrValueExpression _logicalDevice;

		// Token: 0x0400204B RID: 8267
		private ValueExpression _physicalDevice;

		// Token: 0x0400204C RID: 8268
		private DeviceType _deviceType;
	}
}
