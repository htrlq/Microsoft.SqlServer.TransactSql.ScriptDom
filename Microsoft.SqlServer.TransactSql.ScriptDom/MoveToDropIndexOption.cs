using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000320 RID: 800
	[Serializable]
	public class MoveToDropIndexOption : IndexOption
	{
		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06003140 RID: 12608 RVA: 0x001D0289 File Offset: 0x001CE489
		// (set) Token: 0x06003141 RID: 12609 RVA: 0x001D0291 File Offset: 0x001CE491
		public FileGroupOrPartitionScheme MoveTo
		{
			get
			{
				return this._moveTo;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._moveTo = value;
			}
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x001D02A1 File Offset: 0x001CE4A1
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x001D02AD File Offset: 0x001CE4AD
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.MoveTo != null)
			{
				this.MoveTo.Accept(visitor);
			}
		}

		// Token: 0x04001F83 RID: 8067
		private FileGroupOrPartitionScheme _moveTo;
	}
}
