using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200047B RID: 1147
	[Serializable]
	public abstract class ServerAuditStatement : TSqlStatement
	{
		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06003992 RID: 14738 RVA: 0x001D87B0 File Offset: 0x001D69B0
		// (set) Token: 0x06003993 RID: 14739 RVA: 0x001D87B8 File Offset: 0x001D69B8
		public Identifier AuditName
		{
			get
			{
				return this._auditName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._auditName = value;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06003994 RID: 14740 RVA: 0x001D87C8 File Offset: 0x001D69C8
		// (set) Token: 0x06003995 RID: 14741 RVA: 0x001D87D0 File Offset: 0x001D69D0
		public AuditTarget AuditTarget
		{
			get
			{
				return this._auditTarget;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._auditTarget = value;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06003996 RID: 14742 RVA: 0x001D87E0 File Offset: 0x001D69E0
		public IList<AuditOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06003997 RID: 14743 RVA: 0x001D87E8 File Offset: 0x001D69E8
		// (set) Token: 0x06003998 RID: 14744 RVA: 0x001D87F0 File Offset: 0x001D69F0
		public BooleanExpression PredicateExpression
		{
			get
			{
				return this._predicateExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._predicateExpression = value;
			}
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x001D8800 File Offset: 0x001D6A00
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.AuditName != null)
			{
				this.AuditName.Accept(visitor);
			}
			if (this.AuditTarget != null)
			{
				this.AuditTarget.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			if (this.PredicateExpression != null)
			{
				this.PredicateExpression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021DF RID: 8671
		private Identifier _auditName;

		// Token: 0x040021E0 RID: 8672
		private AuditTarget _auditTarget;

		// Token: 0x040021E1 RID: 8673
		private List<AuditOption> _options = new List<AuditOption>();

		// Token: 0x040021E2 RID: 8674
		private BooleanExpression _predicateExpression;
	}
}
