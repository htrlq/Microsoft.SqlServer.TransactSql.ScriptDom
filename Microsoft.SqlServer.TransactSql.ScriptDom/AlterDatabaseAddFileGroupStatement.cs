using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000351 RID: 849
	[Serializable]
	public class AlterDatabaseAddFileGroupStatement : AlterDatabaseStatement
	{
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x001D1299 File Offset: 0x001CF499
		// (set) Token: 0x0600325D RID: 12893 RVA: 0x001D12A1 File Offset: 0x001CF4A1
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

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x0600325E RID: 12894 RVA: 0x001D12B1 File Offset: 0x001CF4B1
		// (set) Token: 0x0600325F RID: 12895 RVA: 0x001D12B9 File Offset: 0x001CF4B9
		public bool ContainsFileStream
		{
			get
			{
				return this._containsFileStream;
			}
			set
			{
				this._containsFileStream = value;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06003260 RID: 12896 RVA: 0x001D12C2 File Offset: 0x001CF4C2
		// (set) Token: 0x06003261 RID: 12897 RVA: 0x001D12CA File Offset: 0x001CF4CA
		public bool ContainsMemoryOptimizedData
		{
			get
			{
				return this._containsMemoryOptimizedData;
			}
			set
			{
				this._containsMemoryOptimizedData = value;
			}
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x001D12D3 File Offset: 0x001CF4D3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x001D12DF File Offset: 0x001CF4DF
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.FileGroup != null)
			{
				this.FileGroup.Accept(visitor);
			}
		}

		// Token: 0x04001FCD RID: 8141
		private Identifier _fileGroup;

		// Token: 0x04001FCE RID: 8142
		private bool _containsFileStream;

		// Token: 0x04001FCF RID: 8143
		private bool _containsMemoryOptimizedData;
	}
}
