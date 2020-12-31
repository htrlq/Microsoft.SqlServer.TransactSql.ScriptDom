using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000428 RID: 1064
	[Serializable]
	public class AlterSearchPropertyListStatement : TSqlStatement
	{
		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060037BE RID: 14270 RVA: 0x001D6B44 File Offset: 0x001D4D44
		// (set) Token: 0x060037BF RID: 14271 RVA: 0x001D6B4C File Offset: 0x001D4D4C
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

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060037C0 RID: 14272 RVA: 0x001D6B5C File Offset: 0x001D4D5C
		// (set) Token: 0x060037C1 RID: 14273 RVA: 0x001D6B64 File Offset: 0x001D4D64
		public SearchPropertyListAction Action
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

		// Token: 0x060037C2 RID: 14274 RVA: 0x001D6B74 File Offset: 0x001D4D74
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x001D6B80 File Offset: 0x001D4D80
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.Action != null)
			{
				this.Action.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002164 RID: 8548
		private Identifier _name;

		// Token: 0x04002165 RID: 8549
		private SearchPropertyListAction _action;
	}
}
