using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001FB RID: 507
	[Serializable]
	public class NamedTableReference : TableReferenceWithAlias
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x001C88C3 File Offset: 0x001C6AC3
		// (set) Token: 0x06002A5F RID: 10847 RVA: 0x001C88CB File Offset: 0x001C6ACB
		public SchemaObjectName SchemaObject
		{
			get
			{
				return this._schemaObject;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._schemaObject = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x001C88DB File Offset: 0x001C6ADB
		public IList<TableHint> TableHints
		{
			get
			{
				return this._tableHints;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06002A61 RID: 10849 RVA: 0x001C88E3 File Offset: 0x001C6AE3
		// (set) Token: 0x06002A62 RID: 10850 RVA: 0x001C88EB File Offset: 0x001C6AEB
		public TableSampleClause TableSampleClause
		{
			get
			{
				return this._tableSampleClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._tableSampleClause = value;
			}
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x001C88FB File Offset: 0x001C6AFB
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x001C8908 File Offset: 0x001C6B08
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SchemaObject != null)
			{
				this.SchemaObject.Accept(visitor);
			}
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.TableHints.Count;
			while (i < count)
			{
				this.TableHints[i].Accept(visitor);
				i++;
			}
			if (this.TableSampleClause != null)
			{
				this.TableSampleClause.Accept(visitor);
			}
		}

		// Token: 0x04001D89 RID: 7561
		private SchemaObjectName _schemaObject;

		// Token: 0x04001D8A RID: 7562
		private List<TableHint> _tableHints = new List<TableHint>();

		// Token: 0x04001D8B RID: 7563
		private TableSampleClause _tableSampleClause;
	}
}
