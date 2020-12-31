using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000350 RID: 848
	[Serializable]
	public class AlterDatabaseAddFileStatement : AlterDatabaseStatement
	{
		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06003254 RID: 12884 RVA: 0x001D11F5 File Offset: 0x001CF3F5
		public IList<FileDeclaration> FileDeclarations
		{
			get
			{
				return this._fileDeclarations;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06003255 RID: 12885 RVA: 0x001D11FD File Offset: 0x001CF3FD
		// (set) Token: 0x06003256 RID: 12886 RVA: 0x001D1205 File Offset: 0x001CF405
		public Identifier FileGroup
		{
			get
			{
				return this._fileGroup;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._fileGroup = value;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x001D1215 File Offset: 0x001CF415
		// (set) Token: 0x06003258 RID: 12888 RVA: 0x001D121D File Offset: 0x001CF41D
		public bool IsLog
		{
			get
			{
				return this._isLog;
			}
			set
			{
				this._isLog = value;
			}
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x001D1226 File Offset: 0x001CF426
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x001D1234 File Offset: 0x001CF434
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.FileDeclarations.Count;
			while (i < count)
			{
				this.FileDeclarations[i].Accept(visitor);
				i++;
			}
			if (this.FileGroup != null)
			{
				this.FileGroup.Accept(visitor);
			}
		}

		// Token: 0x04001FCA RID: 8138
		private List<FileDeclaration> _fileDeclarations = new List<FileDeclaration>();

		// Token: 0x04001FCB RID: 8139
		private Identifier _fileGroup;

		// Token: 0x04001FCC RID: 8140
		private bool _isLog;
	}
}
