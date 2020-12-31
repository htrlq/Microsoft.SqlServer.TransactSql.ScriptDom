using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000214 RID: 532
	[Serializable]
	public class TableHintsOptimizerHint : OptimizerHint
	{
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x001C932C File Offset: 0x001C752C
		// (set) Token: 0x06002AF1 RID: 10993 RVA: 0x001C9334 File Offset: 0x001C7534
		public SchemaObjectName ObjectName
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

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06002AF2 RID: 10994 RVA: 0x001C9344 File Offset: 0x001C7544
		public IList<TableHint> TableHints
		{
			get
			{
				return this._tableHints;
			}
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x001C934C File Offset: 0x001C754C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x001C9358 File Offset: 0x001C7558
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.ObjectName != null)
			{
				this.ObjectName.Accept(visitor);
			}
			int i = 0;
			int count = this.TableHints.Count;
			while (i < count)
			{
				this.TableHints[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001DB4 RID: 7604
		private SchemaObjectName _objectName;

		// Token: 0x04001DB5 RID: 7605
		private List<TableHint> _tableHints = new List<TableHint>();
	}
}
