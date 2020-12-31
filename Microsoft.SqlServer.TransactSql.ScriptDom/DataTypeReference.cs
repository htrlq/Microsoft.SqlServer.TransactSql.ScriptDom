using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001EF RID: 495
	[Serializable]
	public abstract class DataTypeReference : TSqlFragment
	{
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x001C84F3 File Offset: 0x001C66F3
		// (set) Token: 0x06002A25 RID: 10789 RVA: 0x001C84FB File Offset: 0x001C66FB
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

		// Token: 0x06002A26 RID: 10790 RVA: 0x001C850B File Offset: 0x001C670B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D7A RID: 7546
		private SchemaObjectName _name;
	}
}
