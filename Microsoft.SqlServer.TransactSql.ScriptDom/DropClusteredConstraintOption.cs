using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002B4 RID: 692
	[Serializable]
	public abstract class DropClusteredConstraintOption : TSqlFragment
	{
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x001CD76D File Offset: 0x001CB96D
		// (set) Token: 0x06002EC3 RID: 11971 RVA: 0x001CD775 File Offset: 0x001CB975
		public DropClusteredConstraintOptionKind OptionKind
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

		// Token: 0x06002EC4 RID: 11972 RVA: 0x001CD77E File Offset: 0x001CB97E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001ECD RID: 7885
		private DropClusteredConstraintOptionKind _optionKind;
	}
}
