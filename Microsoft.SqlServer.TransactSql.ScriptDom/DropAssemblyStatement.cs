using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000410 RID: 1040
	[Serializable]
	public class DropAssemblyStatement : DropObjectsStatement
	{
		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06003745 RID: 14149 RVA: 0x001D64E5 File Offset: 0x001D46E5
		// (set) Token: 0x06003746 RID: 14150 RVA: 0x001D64ED File Offset: 0x001D46ED
		public bool WithNoDependents
		{
			get
			{
				return this._withNoDependents;
			}
			set
			{
				this._withNoDependents = value;
			}
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x001D64F6 File Offset: 0x001D46F6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x001D6502 File Offset: 0x001D4702
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400214A RID: 8522
		private bool _withNoDependents;
	}
}
