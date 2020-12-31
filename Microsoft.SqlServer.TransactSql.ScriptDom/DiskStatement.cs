using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004E1 RID: 1249
	[Serializable]
	public class DiskStatement : TSqlStatement
	{
		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06003BCE RID: 15310 RVA: 0x001DAA68 File Offset: 0x001D8C68
		// (set) Token: 0x06003BCF RID: 15311 RVA: 0x001DAA70 File Offset: 0x001D8C70
		public DiskStatementType DiskStatementType
		{
			get
			{
				return this._diskStatementType;
			}
			set
			{
				this._diskStatementType = value;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06003BD0 RID: 15312 RVA: 0x001DAA79 File Offset: 0x001D8C79
		public IList<DiskStatementOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x001DAA81 File Offset: 0x001D8C81
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x001DAA90 File Offset: 0x001D8C90
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002278 RID: 8824
		private DiskStatementType _diskStatementType;

		// Token: 0x04002279 RID: 8825
		private List<DiskStatementOption> _options = new List<DiskStatementOption>();
	}
}
