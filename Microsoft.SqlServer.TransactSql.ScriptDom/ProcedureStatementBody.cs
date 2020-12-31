using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001DD RID: 477
	[Serializable]
	public abstract class ProcedureStatementBody : ProcedureStatementBodyBase
	{
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060029C3 RID: 10691 RVA: 0x001C7D25 File Offset: 0x001C5F25
		// (set) Token: 0x060029C4 RID: 10692 RVA: 0x001C7D2D File Offset: 0x001C5F2D
		public ProcedureReference ProcedureReference
		{
			get
			{
				return this._procedureReference;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._procedureReference = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060029C5 RID: 10693 RVA: 0x001C7D3D File Offset: 0x001C5F3D
		// (set) Token: 0x060029C6 RID: 10694 RVA: 0x001C7D45 File Offset: 0x001C5F45
		public bool IsForReplication
		{
			get
			{
				return this._isForReplication;
			}
			set
			{
				this._isForReplication = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060029C7 RID: 10695 RVA: 0x001C7D4E File Offset: 0x001C5F4E
		public IList<ProcedureOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x001C7D58 File Offset: 0x001C5F58
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.ProcedureReference != null)
			{
				this.ProcedureReference.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001D60 RID: 7520
		private ProcedureReference _procedureReference;

		// Token: 0x04001D61 RID: 7521
		private bool _isForReplication;

		// Token: 0x04001D62 RID: 7522
		private List<ProcedureOption> _options = new List<ProcedureOption>();
	}
}
