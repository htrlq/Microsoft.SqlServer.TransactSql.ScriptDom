using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200041F RID: 1055
	[Serializable]
	public class AlterFullTextIndexStatement : TSqlStatement
	{
		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06003786 RID: 14214 RVA: 0x001D67E4 File Offset: 0x001D49E4
		// (set) Token: 0x06003787 RID: 14215 RVA: 0x001D67EC File Offset: 0x001D49EC
		public SchemaObjectName OnName
		{
			get
			{
				return this._onName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._onName = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06003788 RID: 14216 RVA: 0x001D67FC File Offset: 0x001D49FC
		// (set) Token: 0x06003789 RID: 14217 RVA: 0x001D6804 File Offset: 0x001D4A04
		public AlterFullTextIndexAction Action
		{
			get
			{
				return this._action;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._action = value;
			}
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x001D6814 File Offset: 0x001D4A14
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x001D6820 File Offset: 0x001D4A20
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.OnName != null)
			{
				this.OnName.Accept(visitor);
			}
			if (this.Action != null)
			{
				this.Action.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002154 RID: 8532
		private SchemaObjectName _onName;

		// Token: 0x04002155 RID: 8533
		private AlterFullTextIndexAction _action;
	}
}
