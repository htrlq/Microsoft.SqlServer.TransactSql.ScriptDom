using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000223 RID: 547
	[Serializable]
	public class OpenXmlTableReference : TableReferenceWithAlias
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x001C9B5D File Offset: 0x001C7D5D
		// (set) Token: 0x06002B5A RID: 11098 RVA: 0x001C9B65 File Offset: 0x001C7D65
		public VariableReference Variable
		{
			get
			{
				return this._variable;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._variable = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06002B5B RID: 11099 RVA: 0x001C9B75 File Offset: 0x001C7D75
		// (set) Token: 0x06002B5C RID: 11100 RVA: 0x001C9B7D File Offset: 0x001C7D7D
		public ValueExpression RowPattern
		{
			get
			{
				return this._rowPattern;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._rowPattern = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06002B5D RID: 11101 RVA: 0x001C9B8D File Offset: 0x001C7D8D
		// (set) Token: 0x06002B5E RID: 11102 RVA: 0x001C9B95 File Offset: 0x001C7D95
		public ValueExpression Flags
		{
			get
			{
				return this._flags;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._flags = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06002B5F RID: 11103 RVA: 0x001C9BA5 File Offset: 0x001C7DA5
		public IList<SchemaDeclarationItem> SchemaDeclarationItems
		{
			get
			{
				return this._schemaDeclarationItems;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06002B60 RID: 11104 RVA: 0x001C9BAD File Offset: 0x001C7DAD
		// (set) Token: 0x06002B61 RID: 11105 RVA: 0x001C9BB5 File Offset: 0x001C7DB5
		public SchemaObjectName TableName
		{
			get
			{
				return this._tableName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._tableName = value;
			}
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x001C9BC5 File Offset: 0x001C7DC5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x001C9BD4 File Offset: 0x001C7DD4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Variable != null)
			{
				this.Variable.Accept(visitor);
			}
			if (this.RowPattern != null)
			{
				this.RowPattern.Accept(visitor);
			}
			if (this.Flags != null)
			{
				this.Flags.Accept(visitor);
			}
			int i = 0;
			int count = this.SchemaDeclarationItems.Count;
			while (i < count)
			{
				this.SchemaDeclarationItems[i].Accept(visitor);
				i++;
			}
			if (this.TableName != null)
			{
				this.TableName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001DD7 RID: 7639
		private VariableReference _variable;

		// Token: 0x04001DD8 RID: 7640
		private ValueExpression _rowPattern;

		// Token: 0x04001DD9 RID: 7641
		private ValueExpression _flags;

		// Token: 0x04001DDA RID: 7642
		private List<SchemaDeclarationItem> _schemaDeclarationItems = new List<SchemaDeclarationItem>();

		// Token: 0x04001DDB RID: 7643
		private SchemaObjectName _tableName;
	}
}
