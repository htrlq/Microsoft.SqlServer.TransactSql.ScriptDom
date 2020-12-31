using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001C2 RID: 450
	[Serializable]
	public class ExecuteStatement : TSqlStatement
	{
		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600291A RID: 10522 RVA: 0x001C71CA File Offset: 0x001C53CA
		// (set) Token: 0x0600291B RID: 10523 RVA: 0x001C71D2 File Offset: 0x001C53D2
		public ExecuteSpecification ExecuteSpecification
		{
			get
			{
				return this._executeSpecification;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._executeSpecification = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600291C RID: 10524 RVA: 0x001C71E2 File Offset: 0x001C53E2
		public IList<ExecuteOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x001C71EA File Offset: 0x001C53EA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x001C71F8 File Offset: 0x001C53F8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ExecuteSpecification != null)
			{
				this.ExecuteSpecification.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D2D RID: 7469
		private ExecuteSpecification _executeSpecification;

		// Token: 0x04001D2E RID: 7470
		private List<ExecuteOption> _options = new List<ExecuteOption>();
	}
}
