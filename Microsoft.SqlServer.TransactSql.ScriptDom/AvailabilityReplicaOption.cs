using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004D1 RID: 1233
	[Serializable]
	public abstract class AvailabilityReplicaOption : TSqlFragment
	{
		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06003B73 RID: 15219 RVA: 0x001DA585 File Offset: 0x001D8785
		// (set) Token: 0x06003B74 RID: 15220 RVA: 0x001DA58D File Offset: 0x001D878D
		public AvailabilityReplicaOptionKind OptionKind
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

		// Token: 0x06003B75 RID: 15221 RVA: 0x001DA596 File Offset: 0x001D8796
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002261 RID: 8801
		private AvailabilityReplicaOptionKind _optionKind;
	}
}
