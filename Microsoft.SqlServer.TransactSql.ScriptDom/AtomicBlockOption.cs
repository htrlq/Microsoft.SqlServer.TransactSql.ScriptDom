using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000241 RID: 577
	[Serializable]
	public abstract class AtomicBlockOption : TSqlFragment
	{
		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06002C2A RID: 11306 RVA: 0x001CABB9 File Offset: 0x001C8DB9
		// (set) Token: 0x06002C2B RID: 11307 RVA: 0x001CABC1 File Offset: 0x001C8DC1
		public AtomicBlockOptionKind OptionKind
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

		// Token: 0x06002C2C RID: 11308 RVA: 0x001CABCA File Offset: 0x001C8DCA
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E18 RID: 7704
		private AtomicBlockOptionKind _optionKind;
	}
}
