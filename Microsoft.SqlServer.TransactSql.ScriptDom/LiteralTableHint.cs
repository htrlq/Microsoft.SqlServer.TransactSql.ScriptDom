using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000200 RID: 512
	[Serializable]
	public class LiteralTableHint : TableHint
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06002A78 RID: 10872 RVA: 0x001C8B05 File Offset: 0x001C6D05
		// (set) Token: 0x06002A79 RID: 10873 RVA: 0x001C8B0D File Offset: 0x001C6D0D
		public Literal Value
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

		// Token: 0x06002A7A RID: 10874 RVA: 0x001C8B1D File Offset: 0x001C6D1D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x001C8B29 File Offset: 0x001C6D29
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x04001D91 RID: 7569
		private Literal _value;
	}
}
