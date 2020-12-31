using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002A4 RID: 676
	[Serializable]
	public class AlterTableChangeTrackingModificationStatement : AlterTableStatement
	{
		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06002E68 RID: 11880 RVA: 0x001CD216 File Offset: 0x001CB416
		// (set) Token: 0x06002E69 RID: 11881 RVA: 0x001CD21E File Offset: 0x001CB41E
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

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06002E6A RID: 11882 RVA: 0x001CD227 File Offset: 0x001CB427
		// (set) Token: 0x06002E6B RID: 11883 RVA: 0x001CD22F File Offset: 0x001CB42F
		public OptionState TrackColumnsUpdated
		{
			get
			{
				return this._trackColumnsUpdated;
			}
			set
			{
				this._trackColumnsUpdated = value;
			}
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x001CD238 File Offset: 0x001CB438
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x001CD244 File Offset: 0x001CB444
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.SchemaObjectName != null)
			{
				base.SchemaObjectName.Accept(visitor);
			}
		}

		// Token: 0x04001EB5 RID: 7861
		private bool _isEnable;

		// Token: 0x04001EB6 RID: 7862
		private OptionState _trackColumnsUpdated;
	}
}
