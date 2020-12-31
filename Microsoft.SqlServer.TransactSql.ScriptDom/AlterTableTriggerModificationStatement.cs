using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002BA RID: 698
	[Serializable]
	public class AlterTableTriggerModificationStatement : AlterTableStatement
	{
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06002EE1 RID: 12001 RVA: 0x001CD966 File Offset: 0x001CBB66
		// (set) Token: 0x06002EE2 RID: 12002 RVA: 0x001CD96E File Offset: 0x001CBB6E
		public TriggerEnforcement TriggerEnforcement
		{
			get
			{
				return this._triggerEnforcement;
			}
			set
			{
				this._triggerEnforcement = value;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06002EE3 RID: 12003 RVA: 0x001CD977 File Offset: 0x001CBB77
		// (set) Token: 0x06002EE4 RID: 12004 RVA: 0x001CD97F File Offset: 0x001CBB7F
		public bool All
		{
			get
			{
				return this._all;
			}
			set
			{
				this._all = value;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x001CD988 File Offset: 0x001CBB88
		public IList<Identifier> TriggerNames
		{
			get
			{
				return this._triggerNames;
			}
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x001CD990 File Offset: 0x001CBB90
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x001CD99C File Offset: 0x001CBB9C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.SchemaObjectName != null)
			{
				base.SchemaObjectName.Accept(visitor);
			}
			int i = 0;
			int count = this.TriggerNames.Count;
			while (i < count)
			{
				this.TriggerNames[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001ED5 RID: 7893
		private TriggerEnforcement _triggerEnforcement;

		// Token: 0x04001ED6 RID: 7894
		private bool _all;

		// Token: 0x04001ED7 RID: 7895
		private List<Identifier> _triggerNames = new List<Identifier>();
	}
}
