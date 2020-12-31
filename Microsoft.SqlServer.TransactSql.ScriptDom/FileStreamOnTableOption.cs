using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002A9 RID: 681
	[Serializable]
	public class FileStreamOnTableOption : TableOption
	{
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06002E81 RID: 11905 RVA: 0x001CD362 File Offset: 0x001CB562
		// (set) Token: 0x06002E82 RID: 11906 RVA: 0x001CD36A File Offset: 0x001CB56A
		public IdentifierOrValueExpression Value
		{
			get
			{
				return this._value;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._value = value;
			}
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x001CD37A File Offset: 0x001CB57A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x001CD386 File Offset: 0x001CB586
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x04001EBB RID: 7867
		private IdentifierOrValueExpression _value;
	}
}
