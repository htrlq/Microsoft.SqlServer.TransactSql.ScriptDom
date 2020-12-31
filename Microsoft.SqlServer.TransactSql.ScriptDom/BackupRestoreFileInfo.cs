using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200038C RID: 908
	[Serializable]
	public class BackupRestoreFileInfo : TSqlFragment
	{
		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060033FB RID: 13307 RVA: 0x001D2C0D File Offset: 0x001D0E0D
		public IList<ValueExpression> Items
		{
			get
			{
				return this._items;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060033FC RID: 13308 RVA: 0x001D2C15 File Offset: 0x001D0E15
		// (set) Token: 0x060033FD RID: 13309 RVA: 0x001D2C1D File Offset: 0x001D0E1D
		public BackupRestoreItemKind ItemKind
		{
			get
			{
				return this._itemKind;
			}
			set
			{
				this._itemKind = value;
			}
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x001D2C26 File Offset: 0x001D0E26
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x001D2C34 File Offset: 0x001D0E34
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Items.Count;
			while (i < count)
			{
				this.Items[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400204E RID: 8270
		private List<ValueExpression> _items = new List<ValueExpression>();

		// Token: 0x0400204F RID: 8271
		private BackupRestoreItemKind _itemKind;
	}
}
