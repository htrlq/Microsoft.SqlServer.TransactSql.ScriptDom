using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000291 RID: 657
	[Serializable]
	public class DataTypeSequenceOption : SequenceOption
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06002E06 RID: 11782 RVA: 0x001CCB20 File Offset: 0x001CAD20
		// (set) Token: 0x06002E07 RID: 11783 RVA: 0x001CCB28 File Offset: 0x001CAD28
		public DataTypeReference DataType
		{
			get
			{
				return this._dataType;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._dataType = value;
			}
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x001CCB38 File Offset: 0x001CAD38
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x001CCB44 File Offset: 0x001CAD44
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.DataType != null)
			{
				this.DataType.Accept(visitor);
			}
		}

		// Token: 0x04001E9C RID: 7836
		private DataTypeReference _dataType;
	}
}
