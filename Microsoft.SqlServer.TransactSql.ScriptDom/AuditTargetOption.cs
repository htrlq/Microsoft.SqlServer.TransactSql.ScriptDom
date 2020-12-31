using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000485 RID: 1157
	[Serializable]
	public abstract class AuditTargetOption : TSqlFragment
	{
		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060039C6 RID: 14790 RVA: 0x001D8AA9 File Offset: 0x001D6CA9
		// (set) Token: 0x060039C7 RID: 14791 RVA: 0x001D8AB1 File Offset: 0x001D6CB1
		public AuditTargetOptionKind OptionKind
		{
			get
			{
				return this._optionKind;
			}
			set
			{
				this._optionKind = value;
			}
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x001D8ABA File Offset: 0x001D6CBA
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021EC RID: 8684
		private AuditTargetOptionKind _optionKind;
	}
}
