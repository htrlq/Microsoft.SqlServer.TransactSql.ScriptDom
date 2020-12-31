using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200032A RID: 810
	[Serializable]
	public class DropSchemaStatement : TSqlStatement
	{
		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06003164 RID: 12644 RVA: 0x001D0414 File Offset: 0x001CE614
		// (set) Token: 0x06003165 RID: 12645 RVA: 0x001D041C File Offset: 0x001CE61C
		public SchemaObjectName Schema
		{
			get
			{
				return this._schema;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._schema = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06003166 RID: 12646 RVA: 0x001D042C File Offset: 0x001CE62C
		// (set) Token: 0x06003167 RID: 12647 RVA: 0x001D0434 File Offset: 0x001CE634
		public DropSchemaBehavior DropBehavior
		{
			get
			{
				return this._dropBehavior;
			}
			set
			{
				this._dropBehavior = value;
			}
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x001D043D File Offset: 0x001CE63D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x001D0449 File Offset: 0x001CE649
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Schema != null)
			{
				this.Schema.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F86 RID: 8070
		private SchemaObjectName _schema;

		// Token: 0x04001F87 RID: 8071
		private DropSchemaBehavior _dropBehavior;
	}
}
