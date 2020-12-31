using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003AE RID: 942
	[Serializable]
	public abstract class MessageTypeStatementBase : TSqlStatement
	{
		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060034D9 RID: 13529 RVA: 0x001D3BAE File Offset: 0x001D1DAE
		// (set) Token: 0x060034DA RID: 13530 RVA: 0x001D3BB6 File Offset: 0x001D1DB6
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

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060034DB RID: 13531 RVA: 0x001D3BC6 File Offset: 0x001D1DC6
		// (set) Token: 0x060034DC RID: 13532 RVA: 0x001D3BCE File Offset: 0x001D1DCE
		public MessageValidationMethod ValidationMethod
		{
			get
			{
				return this._validationMethod;
			}
			set
			{
				this._validationMethod = value;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060034DD RID: 13533 RVA: 0x001D3BD7 File Offset: 0x001D1DD7
		// (set) Token: 0x060034DE RID: 13534 RVA: 0x001D3BDF File Offset: 0x001D1DDF
		public SchemaObjectName XmlSchemaCollectionName
		{
			get
			{
				return this._xmlSchemaCollectionName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._xmlSchemaCollectionName = value;
			}
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x001D3BEF File Offset: 0x001D1DEF
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.XmlSchemaCollectionName != null)
			{
				this.XmlSchemaCollectionName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002093 RID: 8339
		private Identifier _name;

		// Token: 0x04002094 RID: 8340
		private MessageValidationMethod _validationMethod;

		// Token: 0x04002095 RID: 8341
		private SchemaObjectName _xmlSchemaCollectionName;
	}
}
