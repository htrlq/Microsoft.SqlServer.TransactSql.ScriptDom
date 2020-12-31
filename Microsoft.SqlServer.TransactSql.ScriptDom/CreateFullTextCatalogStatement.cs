using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003D5 RID: 981
	[Serializable]
	public class CreateFullTextCatalogStatement : FullTextCatalogStatement, IAuthorization
	{
		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060035CC RID: 13772 RVA: 0x001D4A49 File Offset: 0x001D2C49
		// (set) Token: 0x060035CD RID: 13773 RVA: 0x001D4A51 File Offset: 0x001D2C51
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

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060035CE RID: 13774 RVA: 0x001D4A61 File Offset: 0x001D2C61
		// (set) Token: 0x060035CF RID: 13775 RVA: 0x001D4A69 File Offset: 0x001D2C69
		public Literal Path
		{
			get
			{
				return this._path;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._path = value;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060035D0 RID: 13776 RVA: 0x001D4A79 File Offset: 0x001D2C79
		// (set) Token: 0x060035D1 RID: 13777 RVA: 0x001D4A81 File Offset: 0x001D2C81
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

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060035D2 RID: 13778 RVA: 0x001D4A8A File Offset: 0x001D2C8A
		// (set) Token: 0x060035D3 RID: 13779 RVA: 0x001D4A92 File Offset: 0x001D2C92
		public Identifier Owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._owner = value;
			}
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x001D4AA2 File Offset: 0x001D2CA2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x001D4AB0 File Offset: 0x001D2CB0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			if (this.FileGroup != null)
			{
				this.FileGroup.Accept(visitor);
			}
			if (this.Path != null)
			{
				this.Path.Accept(visitor);
			}
			int i = 0;
			int count = base.Options.Count;
			while (i < count)
			{
				base.Options[i].Accept(visitor);
				i++;
			}
			if (this.Owner != null)
			{
				this.Owner.Accept(visitor);
			}
		}

		// Token: 0x040020D9 RID: 8409
		private Identifier _fileGroup;

		// Token: 0x040020DA RID: 8410
		private Literal _path;

		// Token: 0x040020DB RID: 8411
		private bool _isDefault;

		// Token: 0x040020DC RID: 8412
		private Identifier _owner;
	}
}
