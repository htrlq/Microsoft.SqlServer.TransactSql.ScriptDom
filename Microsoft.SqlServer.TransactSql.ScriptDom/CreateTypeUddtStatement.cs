using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002BF RID: 703
	[Serializable]
	public class CreateTypeUddtStatement : CreateTypeStatement
	{
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x001CDBB5 File Offset: 0x001CBDB5
		// (set) Token: 0x06002F04 RID: 12036 RVA: 0x001CDBBD File Offset: 0x001CBDBD
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

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x001CDBCD File Offset: 0x001CBDCD
		// (set) Token: 0x06002F06 RID: 12038 RVA: 0x001CDBD5 File Offset: 0x001CBDD5
		public NullableConstraintDefinition NullableConstraint
		{
			get
			{
				return this._nullableConstraint;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._nullableConstraint = value;
			}
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x001CDBE5 File Offset: 0x001CBDE5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x001CDBF1 File Offset: 0x001CBDF1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			if (this.DataType != null)
			{
				this.DataType.Accept(visitor);
			}
			if (this.NullableConstraint != null)
			{
				this.NullableConstraint.Accept(visitor);
			}
		}

		// Token: 0x04001EE0 RID: 7904
		private DataTypeReference _dataType;

		// Token: 0x04001EE1 RID: 7905
		private NullableConstraintDefinition _nullableConstraint;
	}
}
