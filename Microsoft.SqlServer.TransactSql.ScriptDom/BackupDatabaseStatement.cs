using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000380 RID: 896
	[Serializable]
	public class BackupDatabaseStatement : BackupStatement
	{
		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060033B0 RID: 13232 RVA: 0x001D2726 File Offset: 0x001D0926
		public IList<BackupRestoreFileInfo> Files
		{
			get
			{
				return this._files;
			}
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x001D272E File Offset: 0x001D092E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x001D273C File Offset: 0x001D093C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.Files.Count;
			while (i < count)
			{
				this.Files[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04002038 RID: 8248
		private List<BackupRestoreFileInfo> _files = new List<BackupRestoreFileInfo>();
	}
}
