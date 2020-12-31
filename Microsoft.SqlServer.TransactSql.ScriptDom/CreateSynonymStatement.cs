using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002C0 RID: 704
	[Serializable]
	public class CreateSynonymStatement : TSqlStatement
	{
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06002F0A RID: 12042 RVA: 0x001CDC37 File Offset: 0x001CBE37
		// (set) Token: 0x06002F0B RID: 12043 RVA: 0x001CDC3F File Offset: 0x001CBE3F
		public SchemaObjectName Name
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

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06002F0C RID: 12044 RVA: 0x001CDC4F File Offset: 0x001CBE4F
		// (set) Token: 0x06002F0D RID: 12045 RVA: 0x001CDC57 File Offset: 0x001CBE57
		public SchemaObjectName ForName
		{
			get
			{
				return this._forName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._forName = value;
			}
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x001CDC67 File Offset: 0x001CBE67
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x001CDC73 File Offset: 0x001CBE73
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.ForName != null)
			{
				this.ForName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EE2 RID: 7906
		private SchemaObjectName _name;

		// Token: 0x04001EE3 RID: 7907
		private SchemaObjectName _forName;
	}
}
