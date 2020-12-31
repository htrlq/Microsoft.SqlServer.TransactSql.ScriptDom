using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200034F RID: 847
	[Serializable]
	public class AlterDatabaseRebuildLogStatement : AlterDatabaseStatement
	{
		// Token: 0x1700039B RID: 923
		// (get) Token: 0x0600324F RID: 12879 RVA: 0x001D11AC File Offset: 0x001CF3AC
		// (set) Token: 0x06003250 RID: 12880 RVA: 0x001D11B4 File Offset: 0x001CF3B4
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

		// Token: 0x06003251 RID: 12881 RVA: 0x001D11C4 File Offset: 0x001CF3C4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x001D11D0 File Offset: 0x001CF3D0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.FileDeclaration != null)
			{
				this.FileDeclaration.Accept(visitor);
			}
		}

		// Token: 0x04001FC9 RID: 8137
		private FileDeclaration _fileDeclaration;
	}
}
