using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200026D RID: 621
	[Serializable]
	public class SecurityTargetObject : TSqlFragment
	{
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06002D3C RID: 11580 RVA: 0x001CBF0A File Offset: 0x001CA10A
		// (set) Token: 0x06002D3D RID: 11581 RVA: 0x001CBF12 File Offset: 0x001CA112
		public SecurityObjectKind ObjectKind
		{
			get
			{
				return this._objectKind;
			}
			set
			{
				this._objectKind = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x001CBF1B File Offset: 0x001CA11B
		// (set) Token: 0x06002D3F RID: 11583 RVA: 0x001CBF23 File Offset: 0x001CA123
		public SecurityTargetObjectName ObjectName
		{
			get
			{
				return this._objectName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._objectName = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x001CBF33 File Offset: 0x001CA133
		public IList<Identifier> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x001CBF3B File Offset: 0x001CA13B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x001CBF48 File Offset: 0x001CA148
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ObjectName != null)
			{
				this.ObjectName.Accept(visitor);
			}
			int i = 0;
			int count = this.Columns.Count;
			while (i < count)
			{
				this.Columns[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E66 RID: 7782
		private SecurityObjectKind _objectKind;

		// Token: 0x04001E67 RID: 7783
		private SecurityTargetObjectName _objectName;

		// Token: 0x04001E68 RID: 7784
		private List<Identifier> _columns = new List<Identifier>();
	}
}
