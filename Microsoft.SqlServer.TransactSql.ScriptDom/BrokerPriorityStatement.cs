using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200049B RID: 1179
	[Serializable]
	public abstract class BrokerPriorityStatement : TSqlStatement
	{
		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06003A35 RID: 14901 RVA: 0x001D9085 File Offset: 0x001D7285
		// (set) Token: 0x06003A36 RID: 14902 RVA: 0x001D908D File Offset: 0x001D728D
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06003A37 RID: 14903 RVA: 0x001D909D File Offset: 0x001D729D
		public IList<BrokerPriorityParameter> BrokerPriorityParameters
		{
			get
			{
				return this._brokerPriorityParameters;
			}
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x001D90A8 File Offset: 0x001D72A8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.BrokerPriorityParameters.Count;
			while (i < count)
			{
				this.BrokerPriorityParameters[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002206 RID: 8710
		private Identifier _name;

		// Token: 0x04002207 RID: 8711
		private List<BrokerPriorityParameter> _brokerPriorityParameters = new List<BrokerPriorityParameter>();
	}
}
