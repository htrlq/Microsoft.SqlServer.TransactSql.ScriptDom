using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200020A RID: 522
	[Serializable]
	public abstract class StatementWithCtesAndXmlNamespaces : TSqlStatement
	{
		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x001C8FFE File Offset: 0x001C71FE
		// (set) Token: 0x06002AC3 RID: 10947 RVA: 0x001C9006 File Offset: 0x001C7206
		public WithCtesAndXmlNamespaces WithCtesAndXmlNamespaces
		{
			get
			{
				return this._withCtesAndXmlNamespaces;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._withCtesAndXmlNamespaces = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x001C9016 File Offset: 0x001C7216
		public IList<OptimizerHint> OptimizerHints
		{
			get
			{
				return this._optimizerHints;
			}
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x001C9020 File Offset: 0x001C7220
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.WithCtesAndXmlNamespaces != null)
			{
				this.WithCtesAndXmlNamespaces.Accept(visitor);
			}
			int i = 0;
			int count = this.OptimizerHints.Count;
			while (i < count)
			{
				this.OptimizerHints[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001DA9 RID: 7593
		private WithCtesAndXmlNamespaces _withCtesAndXmlNamespaces;

		// Token: 0x04001DAA RID: 7594
		private List<OptimizerHint> _optimizerHints = new List<OptimizerHint>();
	}
}
