using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000234 RID: 564
	[Serializable]
	public class UserDefinedTypeCallTarget : CallTarget
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06002BE3 RID: 11235 RVA: 0x001CA5BC File Offset: 0x001C87BC
		// (set) Token: 0x06002BE4 RID: 11236 RVA: 0x001CA5C4 File Offset: 0x001C87C4
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

		// Token: 0x06002BE5 RID: 11237 RVA: 0x001CA5D4 File Offset: 0x001C87D4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x001CA5E0 File Offset: 0x001C87E0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SchemaObjectName != null)
			{
				this.SchemaObjectName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E05 RID: 7685
		private SchemaObjectName _schemaObjectName;
	}
}
