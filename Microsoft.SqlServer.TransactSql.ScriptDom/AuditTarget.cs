using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200047F RID: 1151
	[Serializable]
	public class AuditTarget : TSqlFragment
	{
		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060039A8 RID: 14760 RVA: 0x001D8921 File Offset: 0x001D6B21
		// (set) Token: 0x060039A9 RID: 14761 RVA: 0x001D8929 File Offset: 0x001D6B29
		public AuditTargetKind TargetKind
		{
			get
			{
				return this._targetKind;
			}
			set
			{
				this._targetKind = value;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060039AA RID: 14762 RVA: 0x001D8932 File Offset: 0x001D6B32
		public IList<AuditTargetOption> TargetOptions
		{
			get
			{
				return this._targetOptions;
			}
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x001D893A File Offset: 0x001D6B3A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060039AC RID: 14764 RVA: 0x001D8948 File Offset: 0x001D6B48
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.TargetOptions.Count;
			while (i < count)
			{
				this.TargetOptions[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021E5 RID: 8677
		private AuditTargetKind _targetKind;

		// Token: 0x040021E6 RID: 8678
		private List<AuditTargetOption> _targetOptions = new List<AuditTargetOption>();
	}
}
