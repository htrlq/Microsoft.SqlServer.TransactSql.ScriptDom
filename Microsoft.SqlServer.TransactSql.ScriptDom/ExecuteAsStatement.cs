using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000448 RID: 1096
	[Serializable]
	public class ExecuteAsStatement : TSqlStatement
	{
		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x001D7509 File Offset: 0x001D5709
		// (set) Token: 0x06003866 RID: 14438 RVA: 0x001D7511 File Offset: 0x001D5711
		public bool WithNoRevert
		{
			get
			{
				return this._withNoRevert;
			}
			set
			{
				this._withNoRevert = value;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x001D751A File Offset: 0x001D571A
		// (set) Token: 0x06003868 RID: 14440 RVA: 0x001D7522 File Offset: 0x001D5722
		public VariableReference Cookie
		{
			get
			{
				return this._cookie;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._cookie = value;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06003869 RID: 14441 RVA: 0x001D7532 File Offset: 0x001D5732
		// (set) Token: 0x0600386A RID: 14442 RVA: 0x001D753A File Offset: 0x001D573A
		public ExecuteContext ExecuteContext
		{
			get
			{
				return this._executeContext;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._executeContext = value;
			}
		}

		// Token: 0x0600386B RID: 14443 RVA: 0x001D754A File Offset: 0x001D574A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600386C RID: 14444 RVA: 0x001D7556 File Offset: 0x001D5756
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Cookie != null)
			{
				this.Cookie.Accept(visitor);
			}
			if (this.ExecuteContext != null)
			{
				this.ExecuteContext.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400218C RID: 8588
		private bool _withNoRevert;

		// Token: 0x0400218D RID: 8589
		private VariableReference _cookie;

		// Token: 0x0400218E RID: 8590
		private ExecuteContext _executeContext;
	}
}
