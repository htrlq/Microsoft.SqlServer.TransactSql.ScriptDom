using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001D2 RID: 466
	[Serializable]
	public abstract class ViewStatementBody : TSqlStatement
	{
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600297C RID: 10620 RVA: 0x001C7858 File Offset: 0x001C5A58
		// (set) Token: 0x0600297D RID: 10621 RVA: 0x001C7860 File Offset: 0x001C5A60
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

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600297E RID: 10622 RVA: 0x001C7870 File Offset: 0x001C5A70
		public IList<Identifier> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600297F RID: 10623 RVA: 0x001C7878 File Offset: 0x001C5A78
		public IList<ViewOption> ViewOptions
		{
			get
			{
				return this._viewOptions;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06002980 RID: 10624 RVA: 0x001C7880 File Offset: 0x001C5A80
		// (set) Token: 0x06002981 RID: 10625 RVA: 0x001C7888 File Offset: 0x001C5A88
		public SelectStatement SelectStatement
		{
			get
			{
				return this._selectStatement;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._selectStatement = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06002982 RID: 10626 RVA: 0x001C7898 File Offset: 0x001C5A98
		// (set) Token: 0x06002983 RID: 10627 RVA: 0x001C78A0 File Offset: 0x001C5AA0
		public bool WithCheckOption
		{
			get
			{
				return this._withCheckOption;
			}
			set
			{
				this._withCheckOption = value;
			}
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x001C78AC File Offset: 0x001C5AAC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SchemaObjectName != null)
			{
				this.SchemaObjectName.Accept(visitor);
			}
			int i = 0;
			int count = this.Columns.Count;
			while (i < count)
			{
				this.Columns[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.ViewOptions.Count;
			while (j < count2)
			{
				this.ViewOptions[j].Accept(visitor);
				j++;
			}
			if (this.SelectStatement != null)
			{
				this.SelectStatement.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D49 RID: 7497
		private SchemaObjectName _schemaObjectName;

		// Token: 0x04001D4A RID: 7498
		private List<Identifier> _columns = new List<Identifier>();

		// Token: 0x04001D4B RID: 7499
		private List<ViewOption> _viewOptions = new List<ViewOption>();

		// Token: 0x04001D4C RID: 7500
		private SelectStatement _selectStatement;

		// Token: 0x04001D4D RID: 7501
		private bool _withCheckOption;
	}
}
