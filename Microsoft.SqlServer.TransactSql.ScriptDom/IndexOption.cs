using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002D7 RID: 727
	[Serializable]
	public abstract class IndexOption : TSqlFragment
	{
		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06002FAE RID: 12206 RVA: 0x001CE930 File Offset: 0x001CCB30
		// (set) Token: 0x06002FAF RID: 12207 RVA: 0x001CE938 File Offset: 0x001CCB38
		public IndexOptionKind OptionKind
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

		// Token: 0x06002FB0 RID: 12208 RVA: 0x001CE941 File Offset: 0x001CCB41
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F18 RID: 7960
		private IndexOptionKind _optionKind;
	}
}
