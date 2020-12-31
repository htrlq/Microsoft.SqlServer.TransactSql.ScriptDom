using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200034C RID: 844
	[Serializable]
	public class FileGroupDefinition : TSqlFragment
	{
		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06003238 RID: 12856 RVA: 0x001D1051 File Offset: 0x001CF251
		// (set) Token: 0x06003239 RID: 12857 RVA: 0x001D1059 File Offset: 0x001CF259
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x0600323A RID: 12858 RVA: 0x001D1069 File Offset: 0x001CF269
		public IList<FileDeclaration> FileDeclarations
		{
			get
			{
				return this._fileDeclarations;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x0600323B RID: 12859 RVA: 0x001D1071 File Offset: 0x001CF271
		// (set) Token: 0x0600323C RID: 12860 RVA: 0x001D1079 File Offset: 0x001CF279
		public bool IsDefault
		{
			get
			{
				return this._isDefault;
			}
			set
			{
				this._isDefault = value;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x0600323D RID: 12861 RVA: 0x001D1082 File Offset: 0x001CF282
		// (set) Token: 0x0600323E RID: 12862 RVA: 0x001D108A File Offset: 0x001CF28A
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

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x0600323F RID: 12863 RVA: 0x001D1093 File Offset: 0x001CF293
		// (set) Token: 0x06003240 RID: 12864 RVA: 0x001D109B File Offset: 0x001CF29B
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

		// Token: 0x06003241 RID: 12865 RVA: 0x001D10A4 File Offset: 0x001CF2A4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x001D10B0 File Offset: 0x001CF2B0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.FileDeclarations.Count;
			while (i < count)
			{
				this.FileDeclarations[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FC1 RID: 8129
		private Identifier _name;

		// Token: 0x04001FC2 RID: 8130
		private List<FileDeclaration> _fileDeclarations = new List<FileDeclaration>();

		// Token: 0x04001FC3 RID: 8131
		private bool _isDefault;

		// Token: 0x04001FC4 RID: 8132
		private bool _containsFileStream;

		// Token: 0x04001FC5 RID: 8133
		private bool _containsMemoryOptimizedData;
	}
}
