using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003CD RID: 973
	[Serializable]
	public class AlgorithmKeyOption : KeyOption
	{
		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060035A5 RID: 13733 RVA: 0x001D4813 File Offset: 0x001D2A13
		// (set) Token: 0x060035A6 RID: 13734 RVA: 0x001D481B File Offset: 0x001D2A1B
		public EncryptionAlgorithm Algorithm
		{
			get
			{
				return this._algorithm;
			}
			set
			{
				this._algorithm = value;
			}
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x001D4824 File Offset: 0x001D2A24
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x001D4830 File Offset: 0x001D2A30
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020D0 RID: 8400
		private EncryptionAlgorithm _algorithm;
	}
}
