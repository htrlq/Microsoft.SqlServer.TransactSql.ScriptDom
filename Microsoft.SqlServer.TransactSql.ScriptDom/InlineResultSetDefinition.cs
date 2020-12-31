using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001C6 RID: 454
	[Serializable]
	public class InlineResultSetDefinition : ResultSetDefinition
	{
		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x001C732F File Offset: 0x001C552F
		public IList<ResultColumnDefinition> ResultColumnDefinitions
		{
			get
			{
				return this._resultColumnDefinitions;
			}
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x001C7337 File Offset: 0x001C5537
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x001C7344 File Offset: 0x001C5544
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.ResultColumnDefinitions.Count;
			while (i < count)
			{
				this.ResultColumnDefinitions[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001D33 RID: 7475
		private List<ResultColumnDefinition> _resultColumnDefinitions = new List<ResultColumnDefinition>();
	}
}
