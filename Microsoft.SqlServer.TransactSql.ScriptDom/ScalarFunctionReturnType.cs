using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001F4 RID: 500
	[Serializable]
	public class ScalarFunctionReturnType : FunctionReturnType
	{
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06002A3A RID: 10810 RVA: 0x001C862E File Offset: 0x001C682E
		// (set) Token: 0x06002A3B RID: 10811 RVA: 0x001C8636 File Offset: 0x001C6836
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

		// Token: 0x06002A3C RID: 10812 RVA: 0x001C8646 File Offset: 0x001C6846
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x001C8652 File Offset: 0x001C6852
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.DataType != null)
			{
				this.DataType.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D7F RID: 7551
		private DataTypeReference _dataType;
	}
}
