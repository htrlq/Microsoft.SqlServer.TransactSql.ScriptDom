using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001C4 RID: 452
	[Serializable]
	public class ResultSetsExecuteOption : ExecuteOption
	{
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06002925 RID: 10533 RVA: 0x001C728B File Offset: 0x001C548B
		// (set) Token: 0x06002926 RID: 10534 RVA: 0x001C7293 File Offset: 0x001C5493
		public ResultSetsOptionKind ResultSetsOptionKind
		{
			get
			{
				return this._resultSetsOptionKind;
			}
			set
			{
				this._resultSetsOptionKind = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x001C729C File Offset: 0x001C549C
		public IList<ResultSetDefinition> Definitions
		{
			get
			{
				return this._definitions;
			}
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x001C72A4 File Offset: 0x001C54A4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x001C72B0 File Offset: 0x001C54B0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.Definitions.Count;
			while (i < count)
			{
				this.Definitions[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001D30 RID: 7472
		private ResultSetsOptionKind _resultSetsOptionKind;

		// Token: 0x04001D31 RID: 7473
		private List<ResultSetDefinition> _definitions = new List<ResultSetDefinition>();
	}
}
