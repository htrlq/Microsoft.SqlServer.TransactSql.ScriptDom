using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002AB RID: 683
	[Serializable]
	public class FileTableCollateFileNameTableOption : TableOption
	{
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06002E8B RID: 11915 RVA: 0x001CD3F4 File Offset: 0x001CB5F4
		// (set) Token: 0x06002E8C RID: 11916 RVA: 0x001CD3FC File Offset: 0x001CB5FC
		public Identifier Value
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

		// Token: 0x06002E8D RID: 11917 RVA: 0x001CD40C File Offset: 0x001CB60C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x001CD418 File Offset: 0x001CB618
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x04001EBD RID: 7869
		private Identifier _value;
	}
}
