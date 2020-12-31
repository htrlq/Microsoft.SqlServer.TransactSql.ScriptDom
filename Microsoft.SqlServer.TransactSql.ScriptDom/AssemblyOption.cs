using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200029A RID: 666
	[Serializable]
	public class AssemblyOption : TSqlFragment
	{
		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06002E2E RID: 11822 RVA: 0x001CCE92 File Offset: 0x001CB092
		// (set) Token: 0x06002E2F RID: 11823 RVA: 0x001CCE9A File Offset: 0x001CB09A
		public AssemblyOptionKind OptionKind
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

		// Token: 0x06002E30 RID: 11824 RVA: 0x001CCEA3 File Offset: 0x001CB0A3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x001CCEAF File Offset: 0x001CB0AF
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EA6 RID: 7846
		private AssemblyOptionKind _optionKind;
	}
}
