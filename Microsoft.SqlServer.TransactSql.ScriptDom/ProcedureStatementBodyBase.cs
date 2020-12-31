using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001DC RID: 476
	[Serializable]
	public abstract class ProcedureStatementBodyBase : TSqlStatement
	{
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x001C7C74 File Offset: 0x001C5E74
		public IList<ProcedureParameter> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060029BD RID: 10685 RVA: 0x001C7C7C File Offset: 0x001C5E7C
		// (set) Token: 0x060029BE RID: 10686 RVA: 0x001C7C84 File Offset: 0x001C5E84
		public StatementList StatementList
		{
			get
			{
				return this._statementList;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._statementList = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060029BF RID: 10687 RVA: 0x001C7C94 File Offset: 0x001C5E94
		// (set) Token: 0x060029C0 RID: 10688 RVA: 0x001C7C9C File Offset: 0x001C5E9C
		public MethodSpecifier MethodSpecifier
		{
			get
			{
				return this._methodSpecifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._methodSpecifier = value;
			}
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x001C7CAC File Offset: 0x001C5EAC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Parameters.Count;
			while (i < count)
			{
				this.Parameters[i].Accept(visitor);
				i++;
			}
			if (this.StatementList != null)
			{
				this.StatementList.Accept(visitor);
			}
			if (this.MethodSpecifier != null)
			{
				this.MethodSpecifier.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D5D RID: 7517
		private List<ProcedureParameter> _parameters = new List<ProcedureParameter>();

		// Token: 0x04001D5E RID: 7518
		private StatementList _statementList;

		// Token: 0x04001D5F RID: 7519
		private MethodSpecifier _methodSpecifier;
	}
}
