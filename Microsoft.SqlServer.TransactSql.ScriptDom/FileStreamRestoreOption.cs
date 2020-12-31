using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000387 RID: 903
	[Serializable]
	public class FileStreamRestoreOption : RestoreOption
	{
		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060033DB RID: 13275 RVA: 0x001D2A40 File Offset: 0x001D0C40
		// (set) Token: 0x060033DC RID: 13276 RVA: 0x001D2A48 File Offset: 0x001D0C48
		public FileStreamDatabaseOption FileStreamOption
		{
			get
			{
				return this._fileStreamOption;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._fileStreamOption = value;
			}
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x001D2A58 File Offset: 0x001D0C58
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x001D2A64 File Offset: 0x001D0C64
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.FileStreamOption != null)
			{
				this.FileStreamOption.Accept(visitor);
			}
		}

		// Token: 0x04002045 RID: 8261
		private FileStreamDatabaseOption _fileStreamOption;
	}
}
