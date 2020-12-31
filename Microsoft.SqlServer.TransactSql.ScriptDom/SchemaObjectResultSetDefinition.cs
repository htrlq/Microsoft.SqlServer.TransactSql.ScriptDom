using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001C8 RID: 456
	[Serializable]
	public class SchemaObjectResultSetDefinition : ResultSetDefinition
	{
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x001C740A File Offset: 0x001C560A
		// (set) Token: 0x0600293C RID: 10556 RVA: 0x001C7412 File Offset: 0x001C5612
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

		// Token: 0x0600293D RID: 10557 RVA: 0x001C7422 File Offset: 0x001C5622
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x001C742E File Offset: 0x001C562E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
		}

		// Token: 0x04001D36 RID: 7478
		private SchemaObjectName _name;
	}
}
