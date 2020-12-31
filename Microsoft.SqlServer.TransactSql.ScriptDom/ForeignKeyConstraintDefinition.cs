using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200037C RID: 892
	[Serializable]
	public class ForeignKeyConstraintDefinition : ConstraintDefinition
	{
		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06003388 RID: 13192 RVA: 0x001D23BE File Offset: 0x001D05BE
		public IList<Identifier> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06003389 RID: 13193 RVA: 0x001D23C6 File Offset: 0x001D05C6
		// (set) Token: 0x0600338A RID: 13194 RVA: 0x001D23CE File Offset: 0x001D05CE
		public SchemaObjectName ReferenceTableName
		{
			get
			{
				return this._referenceTableName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._referenceTableName = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600338B RID: 13195 RVA: 0x001D23DE File Offset: 0x001D05DE
		public IList<Identifier> ReferencedTableColumns
		{
			get
			{
				return this._referencedTableColumns;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600338C RID: 13196 RVA: 0x001D23E6 File Offset: 0x001D05E6
		// (set) Token: 0x0600338D RID: 13197 RVA: 0x001D23EE File Offset: 0x001D05EE
		public DeleteUpdateAction DeleteAction
		{
			get
			{
				return this._deleteAction;
			}
			set
			{
				this._deleteAction = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x001D23F7 File Offset: 0x001D05F7
		// (set) Token: 0x0600338F RID: 13199 RVA: 0x001D23FF File Offset: 0x001D05FF
		public DeleteUpdateAction UpdateAction
		{
			get
			{
				return this._updateAction;
			}
			set
			{
				this._updateAction = value;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06003390 RID: 13200 RVA: 0x001D2408 File Offset: 0x001D0608
		// (set) Token: 0x06003391 RID: 13201 RVA: 0x001D2410 File Offset: 0x001D0610
		public bool NotForReplication
		{
			get
			{
				return this._notForReplication;
			}
			set
			{
				this._notForReplication = value;
			}
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x001D2419 File Offset: 0x001D0619
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x001D2428 File Offset: 0x001D0628
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.Columns.Count;
			while (i < count)
			{
				this.Columns[i].Accept(visitor);
				i++;
			}
			if (this.ReferenceTableName != null)
			{
				this.ReferenceTableName.Accept(visitor);
			}
			int j = 0;
			int count2 = this.ReferencedTableColumns.Count;
			while (j < count2)
			{
				this.ReferencedTableColumns[j].Accept(visitor);
				j++;
			}
		}

		// Token: 0x04002026 RID: 8230
		private List<Identifier> _columns = new List<Identifier>();

		// Token: 0x04002027 RID: 8231
		private SchemaObjectName _referenceTableName;

		// Token: 0x04002028 RID: 8232
		private List<Identifier> _referencedTableColumns = new List<Identifier>();

		// Token: 0x04002029 RID: 8233
		private DeleteUpdateAction _deleteAction;

		// Token: 0x0400202A RID: 8234
		private DeleteUpdateAction _updateAction;

		// Token: 0x0400202B RID: 8235
		private bool _notForReplication;
	}
}
