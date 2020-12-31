using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000301 RID: 769
	[Serializable]
	public class StatisticsOption : TSqlFragment
	{
		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x001CF5FC File Offset: 0x001CD7FC
		// (set) Token: 0x0600308B RID: 12427 RVA: 0x001CF604 File Offset: 0x001CD804
		public StatisticsOptionKind OptionKind
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

		// Token: 0x0600308C RID: 12428 RVA: 0x001CF60D File Offset: 0x001CD80D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x001CF619 File Offset: 0x001CD819
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F4F RID: 8015
		private StatisticsOptionKind _optionKind;
	}
}
