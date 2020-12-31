using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000375 RID: 885
	[Serializable]
	public class CreateTableStatement : TSqlStatement, IFileStreamSpecifier
	{
		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x0600334D RID: 13133 RVA: 0x001D1FB7 File Offset: 0x001D01B7
		// (set) Token: 0x0600334E RID: 13134 RVA: 0x001D1FBF File Offset: 0x001D01BF
		public SchemaObjectName SchemaObjectName
		{
			get
			{
				return this._schemaObjectName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._schemaObjectName = value;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x0600334F RID: 13135 RVA: 0x001D1FCF File Offset: 0x001D01CF
		// (set) Token: 0x06003350 RID: 13136 RVA: 0x001D1FD7 File Offset: 0x001D01D7
		public bool AsFileTable
		{
			get
			{
				return this._asFileTable;
			}
			set
			{
				this._asFileTable = value;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06003351 RID: 13137 RVA: 0x001D1FE0 File Offset: 0x001D01E0
		// (set) Token: 0x06003352 RID: 13138 RVA: 0x001D1FE8 File Offset: 0x001D01E8
		public TableDefinition Definition
		{
			get
			{
				return this._definition;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._definition = value;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06003353 RID: 13139 RVA: 0x001D1FF8 File Offset: 0x001D01F8
		// (set) Token: 0x06003354 RID: 13140 RVA: 0x001D2000 File Offset: 0x001D0200
		public FileGroupOrPartitionScheme OnFileGroupOrPartitionScheme
		{
			get
			{
				return this._onFileGroupOrPartitionScheme;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._onFileGroupOrPartitionScheme = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06003355 RID: 13141 RVA: 0x001D2010 File Offset: 0x001D0210
		// (set) Token: 0x06003356 RID: 13142 RVA: 0x001D2018 File Offset: 0x001D0218
		public FederationScheme FederationScheme
		{
			get
			{
				return this._federationScheme;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._federationScheme = value;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06003357 RID: 13143 RVA: 0x001D2028 File Offset: 0x001D0228
		// (set) Token: 0x06003358 RID: 13144 RVA: 0x001D2030 File Offset: 0x001D0230
		public IdentifierOrValueExpression TextImageOn
		{
			get
			{
				return this._textImageOn;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._textImageOn = value;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06003359 RID: 13145 RVA: 0x001D2040 File Offset: 0x001D0240
		public IList<TableOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x0600335A RID: 13146 RVA: 0x001D2048 File Offset: 0x001D0248
		// (set) Token: 0x0600335B RID: 13147 RVA: 0x001D2050 File Offset: 0x001D0250
		public IdentifierOrValueExpression FileStreamOn
		{
			get
			{
				return this._fileStreamOn;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._fileStreamOn = value;
			}
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x001D2060 File Offset: 0x001D0260
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x001D206C File Offset: 0x001D026C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SchemaObjectName != null)
			{
				this.SchemaObjectName.Accept(visitor);
			}
			if (this.Definition != null)
			{
				this.Definition.Accept(visitor);
			}
			if (this.OnFileGroupOrPartitionScheme != null)
			{
				this.OnFileGroupOrPartitionScheme.Accept(visitor);
			}
			if (this.FederationScheme != null)
			{
				this.FederationScheme.Accept(visitor);
			}
			if (this.TextImageOn != null)
			{
				this.TextImageOn.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			if (this.FileStreamOn != null)
			{
				this.FileStreamOn.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002012 RID: 8210
		private SchemaObjectName _schemaObjectName;

		// Token: 0x04002013 RID: 8211
		private bool _asFileTable;

		// Token: 0x04002014 RID: 8212
		private TableDefinition _definition;

		// Token: 0x04002015 RID: 8213
		private FileGroupOrPartitionScheme _onFileGroupOrPartitionScheme;

		// Token: 0x04002016 RID: 8214
		private FederationScheme _federationScheme;

		// Token: 0x04002017 RID: 8215
		private IdentifierOrValueExpression _textImageOn;

		// Token: 0x04002018 RID: 8216
		private List<TableOption> _options = new List<TableOption>();

		// Token: 0x04002019 RID: 8217
		private IdentifierOrValueExpression _fileStreamOn;
	}
}
