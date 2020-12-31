using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000212 RID: 530
	[Serializable]
	public class OptimizerHint : TSqlFragment
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x001C92B5 File Offset: 0x001C74B5
		// (set) Token: 0x06002AE7 RID: 10983 RVA: 0x001C92BD File Offset: 0x001C74BD
		public OptimizerHintKind HintKind
		{
			get
			{
				return this._hintKind;
			}
			set
			{
				this._hintKind = value;
			}
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x001C92C6 File Offset: 0x001C74C6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x001C92D2 File Offset: 0x001C74D2
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001DB2 RID: 7602
		private OptimizerHintKind _hintKind;
	}
}
