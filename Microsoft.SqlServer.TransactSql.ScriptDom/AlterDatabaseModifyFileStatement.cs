using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000355 RID: 853
	[Serializable]
	public class AlterDatabaseModifyFileStatement : AlterDatabaseStatement
	{
		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06003274 RID: 12916 RVA: 0x001D13DF File Offset: 0x001CF5DF
		// (set) Token: 0x06003275 RID: 12917 RVA: 0x001D13E7 File Offset: 0x001CF5E7
		public FileDeclaration FileDeclaration
		{
			get
			{
				return this._fileDeclaration;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._fileDeclaration = value;
			}
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x001D13F7 File Offset: 0x001CF5F7
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x001D1403 File Offset: 0x001CF603
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.FileDeclaration != null)
			{
				this.FileDeclaration.Accept(visitor);
			}
		}

		// Token: 0x04001FD3 RID: 8147
		private FileDeclaration _fileDeclaration;
	}
}
