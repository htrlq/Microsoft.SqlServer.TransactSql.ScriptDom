using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000382 RID: 898
	[Serializable]
	public class RestoreStatement : TSqlStatement
	{
		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060033B7 RID: 13239 RVA: 0x001D27AA File Offset: 0x001D09AA
		// (set) Token: 0x060033B8 RID: 13240 RVA: 0x001D27B2 File Offset: 0x001D09B2
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

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060033B9 RID: 13241 RVA: 0x001D27C2 File Offset: 0x001D09C2
		public IList<DeviceInfo> Devices
		{
			get
			{
				return this._devices;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060033BA RID: 13242 RVA: 0x001D27CA File Offset: 0x001D09CA
		public IList<BackupRestoreFileInfo> Files
		{
			get
			{
				return this._files;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060033BB RID: 13243 RVA: 0x001D27D2 File Offset: 0x001D09D2
		public IList<RestoreOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060033BC RID: 13244 RVA: 0x001D27DA File Offset: 0x001D09DA
		// (set) Token: 0x060033BD RID: 13245 RVA: 0x001D27E2 File Offset: 0x001D09E2
		public RestoreStatementKind Kind
		{
			get
			{
				return this._kind;
			}
			set
			{
				this._kind = value;
			}
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x001D27EB File Offset: 0x001D09EB
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x001D27F8 File Offset: 0x001D09F8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.DatabaseName != null)
			{
				this.DatabaseName.Accept(visitor);
			}
			int i = 0;
			int count = this.Devices.Count;
			while (i < count)
			{
				this.Devices[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.Files.Count;
			while (j < count2)
			{
				this.Files[j].Accept(visitor);
				j++;
			}
			int k = 0;
			int count3 = this.Options.Count;
			while (k < count3)
			{
				this.Options[k].Accept(visitor);
				k++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002039 RID: 8249
		private IdentifierOrValueExpression _databaseName;

		// Token: 0x0400203A RID: 8250
		private List<DeviceInfo> _devices = new List<DeviceInfo>();

		// Token: 0x0400203B RID: 8251
		private List<BackupRestoreFileInfo> _files = new List<BackupRestoreFileInfo>();

		// Token: 0x0400203C RID: 8252
		private List<RestoreOption> _options = new List<RestoreOption>();

		// Token: 0x0400203D RID: 8253
		private RestoreStatementKind _kind;
	}
}
