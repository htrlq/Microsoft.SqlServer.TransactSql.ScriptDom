using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000352 RID: 850
	[Serializable]
	public class AlterDatabaseRemoveFileGroupStatement : AlterDatabaseStatement
	{
		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06003265 RID: 12901 RVA: 0x001D1304 File Offset: 0x001CF504
		// (set) Token: 0x06003266 RID: 12902 RVA: 0x001D130C File Offset: 0x001CF50C
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

		// Token: 0x06003267 RID: 12903 RVA: 0x001D131C File Offset: 0x001CF51C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x001D1328 File Offset: 0x001CF528
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.FileGroup != null)
			{
				this.FileGroup.Accept(visitor);
			}
		}

		// Token: 0x04001FD0 RID: 8144
		private Identifier _fileGroup;
	}
}
