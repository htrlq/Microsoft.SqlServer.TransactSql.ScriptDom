using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002A2 RID: 674
	[Serializable]
	public abstract class AlterTableStatement : TSqlStatement
	{
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06002E5E RID: 11870 RVA: 0x001CD139 File Offset: 0x001CB339
		// (set) Token: 0x06002E5F RID: 11871 RVA: 0x001CD141 File Offset: 0x001CB341
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

		// Token: 0x06002E60 RID: 11872 RVA: 0x001CD151 File Offset: 0x001CB351
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SchemaObjectName != null)
			{
				this.SchemaObjectName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EB2 RID: 7858
		private SchemaObjectName _schemaObjectName;
	}
}
