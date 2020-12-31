using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200020F RID: 527
	[Serializable]
	public class XmlForClause : ForClause
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06002AD7 RID: 10967 RVA: 0x001C9190 File Offset: 0x001C7390
		public IList<XmlForClauseOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x001C9198 File Offset: 0x001C7398
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x001C91A4 File Offset: 0x001C73A4
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

		// Token: 0x04001DAE RID: 7598
		private List<XmlForClauseOption> _options = new List<XmlForClauseOption>();
	}
}
