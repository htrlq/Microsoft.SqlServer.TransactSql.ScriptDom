using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000377 RID: 887
	[Serializable]
	public class TableDataCompressionOption : TableOption
	{
		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06003366 RID: 13158 RVA: 0x001D21AA File Offset: 0x001D03AA
		// (set) Token: 0x06003367 RID: 13159 RVA: 0x001D21B2 File Offset: 0x001D03B2
		public DataCompressionOption DataCompressionOption
		{
			get
			{
				return this._dataCompressionOption;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._dataCompressionOption = value;
			}
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x001D21C2 File Offset: 0x001D03C2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x001D21CE File Offset: 0x001D03CE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.DataCompressionOption != null)
			{
				this.DataCompressionOption.Accept(visitor);
			}
		}

		// Token: 0x0400201C RID: 8220
		private DataCompressionOption _dataCompressionOption;
	}
}
