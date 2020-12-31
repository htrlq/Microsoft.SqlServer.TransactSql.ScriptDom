using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200038B RID: 907
	[Serializable]
	public class MirrorToClause : TSqlFragment
	{
		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060033F7 RID: 13303 RVA: 0x001D2BA8 File Offset: 0x001D0DA8
		public IList<DeviceInfo> Devices
		{
			get
			{
				return this._devices;
			}
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x001D2BB0 File Offset: 0x001D0DB0
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x001D2BBC File Offset: 0x001D0DBC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Devices.Count;
			while (i < count)
			{
				this.Devices[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400204D RID: 8269
		private List<DeviceInfo> _devices = new List<DeviceInfo>();
	}
}
