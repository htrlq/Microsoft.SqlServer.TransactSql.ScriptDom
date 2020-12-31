using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002FB RID: 763
	[Serializable]
	public abstract class DropUnownedObjectStatement : TSqlStatement
	{
		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600306F RID: 12399 RVA: 0x001CF418 File Offset: 0x001CD618
		// (set) Token: 0x06003070 RID: 12400 RVA: 0x001CF420 File Offset: 0x001CD620
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

		// Token: 0x06003071 RID: 12401 RVA: 0x001CF430 File Offset: 0x001CD630
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F49 RID: 8009
		private Identifier _name;
	}
}
