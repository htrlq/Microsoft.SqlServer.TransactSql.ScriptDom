using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000345 RID: 837
	[Serializable]
	public class FileDeclaration : TSqlFragment
	{
		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600320A RID: 12810 RVA: 0x001D0DEA File Offset: 0x001CEFEA
		public IList<FileDeclarationOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x0600320B RID: 12811 RVA: 0x001D0DF2 File Offset: 0x001CEFF2
		// (set) Token: 0x0600320C RID: 12812 RVA: 0x001D0DFA File Offset: 0x001CEFFA
		public bool IsPrimary
		{
			get
			{
				return this._isPrimary;
			}
			set
			{
				this._isPrimary = value;
			}
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x001D0E03 File Offset: 0x001CF003
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x001D0E10 File Offset: 0x001CF010
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

		// Token: 0x04001FB4 RID: 8116
		private List<FileDeclarationOption> _options = new List<FileDeclarationOption>();

		// Token: 0x04001FB5 RID: 8117
		private bool _isPrimary;
	}
}
