using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000216 RID: 534
	[Serializable]
	public class OptimizeForOptimizerHint : OptimizerHint
	{
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06002AFC RID: 11004 RVA: 0x001C9451 File Offset: 0x001C7651
		public IList<VariableValuePair> Pairs
		{
			get
			{
				return this._pairs;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x001C9459 File Offset: 0x001C7659
		// (set) Token: 0x06002AFE RID: 11006 RVA: 0x001C9461 File Offset: 0x001C7661
		public bool IsForUnknown
		{
			get
			{
				return this._isForUnknown;
			}
			set
			{
				this._isForUnknown = value;
			}
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x001C946A File Offset: 0x001C766A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x001C9478 File Offset: 0x001C7678
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.Pairs.Count;
			while (i < count)
			{
				this.Pairs[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001DB8 RID: 7608
		private List<VariableValuePair> _pairs = new List<VariableValuePair>();

		// Token: 0x04001DB9 RID: 7609
		private bool _isForUnknown;
	}
}
