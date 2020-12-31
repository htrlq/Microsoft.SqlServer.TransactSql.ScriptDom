using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200046F RID: 1135
	[Serializable]
	public abstract class AuditSpecificationStatement : TSqlStatement
	{
		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x0600395D RID: 14685 RVA: 0x001D84A9 File Offset: 0x001D66A9
		// (set) Token: 0x0600395E RID: 14686 RVA: 0x001D84B1 File Offset: 0x001D66B1
		public OptionState AuditState
		{
			get
			{
				return this._auditState;
			}
			set
			{
				this._auditState = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x0600395F RID: 14687 RVA: 0x001D84BA File Offset: 0x001D66BA
		public IList<AuditSpecificationPart> Parts
		{
			get
			{
				return this._parts;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06003960 RID: 14688 RVA: 0x001D84C2 File Offset: 0x001D66C2
		// (set) Token: 0x06003961 RID: 14689 RVA: 0x001D84CA File Offset: 0x001D66CA
		public Identifier SpecificationName
		{
			get
			{
				return this._specificationName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._specificationName = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06003962 RID: 14690 RVA: 0x001D84DA File Offset: 0x001D66DA
		// (set) Token: 0x06003963 RID: 14691 RVA: 0x001D84E2 File Offset: 0x001D66E2
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

		// Token: 0x06003964 RID: 14692 RVA: 0x001D84F4 File Offset: 0x001D66F4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Parts.Count;
			while (i < count)
			{
				this.Parts[i].Accept(visitor);
				i++;
			}
			if (this.SpecificationName != null)
			{
				this.SpecificationName.Accept(visitor);
			}
			if (this.AuditName != null)
			{
				this.AuditName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021D4 RID: 8660
		private OptionState _auditState;

		// Token: 0x040021D5 RID: 8661
		private List<AuditSpecificationPart> _parts = new List<AuditSpecificationPart>();

		// Token: 0x040021D6 RID: 8662
		private Identifier _specificationName;

		// Token: 0x040021D7 RID: 8663
		private Identifier _auditName;
	}
}
