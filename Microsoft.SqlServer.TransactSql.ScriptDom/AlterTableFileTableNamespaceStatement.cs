using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002A5 RID: 677
	[Serializable]
	public class AlterTableFileTableNamespaceStatement : AlterTableStatement
	{
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06002E6F RID: 11887 RVA: 0x001CD262 File Offset: 0x001CB462
		// (set) Token: 0x06002E70 RID: 11888 RVA: 0x001CD26A File Offset: 0x001CB46A
		public bool IsEnable
		{
			get
			{
				return this._isEnable;
			}
			set
			{
				this._isEnable = value;
			}
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x001CD273 File Offset: 0x001CB473
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x001CD27F File Offset: 0x001CB47F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.SchemaObjectName != null)
			{
				base.SchemaObjectName.Accept(visitor);
			}
		}

		// Token: 0x04001EB7 RID: 7863
		private bool _isEnable;
	}
}
