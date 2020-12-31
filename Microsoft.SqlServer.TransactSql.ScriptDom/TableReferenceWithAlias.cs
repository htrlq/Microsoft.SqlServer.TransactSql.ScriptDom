using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001FA RID: 506
	[Serializable]
	public abstract class TableReferenceWithAlias : TableReference
	{
		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x001C8886 File Offset: 0x001C6A86
		// (set) Token: 0x06002A5B RID: 10843 RVA: 0x001C888E File Offset: 0x001C6A8E
		public Identifier Alias
		{
			get
			{
				return this._alias;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._alias = value;
			}
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x001C889E File Offset: 0x001C6A9E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Alias != null)
			{
				this.Alias.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D88 RID: 7560
		private Identifier _alias;
	}
}
