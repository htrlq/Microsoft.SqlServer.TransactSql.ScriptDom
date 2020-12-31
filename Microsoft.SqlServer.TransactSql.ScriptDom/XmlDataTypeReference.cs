using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001F3 RID: 499
	[Serializable]
	public class XmlDataTypeReference : DataTypeReference
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06002A33 RID: 10803 RVA: 0x001C85D4 File Offset: 0x001C67D4
		// (set) Token: 0x06002A34 RID: 10804 RVA: 0x001C85DC File Offset: 0x001C67DC
		public XmlDataTypeOption XmlDataTypeOption
		{
			get
			{
				return this._xmlDataTypeOption;
			}
			set
			{
				this._xmlDataTypeOption = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06002A35 RID: 10805 RVA: 0x001C85E5 File Offset: 0x001C67E5
		// (set) Token: 0x06002A36 RID: 10806 RVA: 0x001C85ED File Offset: 0x001C67ED
		public SchemaObjectName XmlSchemaCollection
		{
			get
			{
				return this._xmlSchemaCollection;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._xmlSchemaCollection = value;
			}
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x001C85FD File Offset: 0x001C67FD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x001C8609 File Offset: 0x001C6809
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.XmlSchemaCollection != null)
			{
				this.XmlSchemaCollection.Accept(visitor);
			}
		}

		// Token: 0x04001D7D RID: 7549
		private XmlDataTypeOption _xmlDataTypeOption;

		// Token: 0x04001D7E RID: 7550
		private SchemaObjectName _xmlSchemaCollection;
	}
}
