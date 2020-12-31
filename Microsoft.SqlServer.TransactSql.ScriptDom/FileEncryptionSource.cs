using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003A3 RID: 931
	[Serializable]
	public class FileEncryptionSource : EncryptionSource
	{
		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600348B RID: 13451 RVA: 0x001D360A File Offset: 0x001D180A
		// (set) Token: 0x0600348C RID: 13452 RVA: 0x001D3612 File Offset: 0x001D1812
		public bool IsExecutable
		{
			get
			{
				return this._isExecutable;
			}
			set
			{
				this._isExecutable = value;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x0600348D RID: 13453 RVA: 0x001D361B File Offset: 0x001D181B
		// (set) Token: 0x0600348E RID: 13454 RVA: 0x001D3623 File Offset: 0x001D1823
		public Literal File
		{
			get
			{
				return this._file;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._file = value;
			}
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x001D3633 File Offset: 0x001D1833
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x001D363F File Offset: 0x001D183F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.File != null)
			{
				this.File.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400207A RID: 8314
		private bool _isExecutable;

		// Token: 0x0400207B RID: 8315
		private Literal _file;
	}
}
