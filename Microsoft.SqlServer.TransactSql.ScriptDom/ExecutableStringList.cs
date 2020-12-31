using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001CF RID: 463
	[Serializable]
	public class ExecutableStringList : ExecutableEntity
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600296C RID: 10604 RVA: 0x001C774F File Offset: 0x001C594F
		public IList<ValueExpression> Strings
		{
			get
			{
				return this._strings;
			}
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x001C7757 File Offset: 0x001C5957
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x001C7764 File Offset: 0x001C5964
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.Strings.Count;
			while (i < count)
			{
				this.Strings[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001D45 RID: 7493
		private List<ValueExpression> _strings = new List<ValueExpression>();
	}
}
