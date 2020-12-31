using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200037F RID: 895
	[Serializable]
	public abstract class BackupStatement : TSqlStatement
	{
		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060033A9 RID: 13225 RVA: 0x001D261E File Offset: 0x001D081E
		// (set) Token: 0x060033AA RID: 13226 RVA: 0x001D2626 File Offset: 0x001D0826
		public IdentifierOrValueExpression DatabaseName
		{
			get
			{
				return this._databaseName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._databaseName = value;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060033AB RID: 13227 RVA: 0x001D2636 File Offset: 0x001D0836
		public IList<BackupOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060033AC RID: 13228 RVA: 0x001D263E File Offset: 0x001D083E
		public IList<MirrorToClause> MirrorToClauses
		{
			get
			{
				return this._mirrorToClauses;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060033AD RID: 13229 RVA: 0x001D2646 File Offset: 0x001D0846
		public IList<DeviceInfo> Devices
		{
			get
			{
				return this._devices;
			}
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x001D2650 File Offset: 0x001D0850
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.DatabaseName != null)
			{
				this.DatabaseName.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.MirrorToClauses.Count;
			while (j < count2)
			{
				this.MirrorToClauses[j].Accept(visitor);
				j++;
			}
			int k = 0;
			int count3 = this.Devices.Count;
			while (k < count3)
			{
				this.Devices[k].Accept(visitor);
				k++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002034 RID: 8244
		private IdentifierOrValueExpression _databaseName;

		// Token: 0x04002035 RID: 8245
		private List<BackupOption> _options = new List<BackupOption>();

		// Token: 0x04002036 RID: 8246
		private List<MirrorToClause> _mirrorToClauses = new List<MirrorToClause>();

		// Token: 0x04002037 RID: 8247
		private List<DeviceInfo> _devices = new List<DeviceInfo>();
	}
}
