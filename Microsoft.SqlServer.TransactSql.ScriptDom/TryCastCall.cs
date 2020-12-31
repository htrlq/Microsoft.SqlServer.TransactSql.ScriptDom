using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200022F RID: 559
	[Serializable]
	public class TryCastCall : PrimaryExpression
	{
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x001CA37D File Offset: 0x001C857D
		// (set) Token: 0x06002BC3 RID: 11203 RVA: 0x001CA385 File Offset: 0x001C8585
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

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x001CA395 File Offset: 0x001C8595
		// (set) Token: 0x06002BC5 RID: 11205 RVA: 0x001CA39D File Offset: 0x001C859D
		public ScalarExpression Parameter
		{
			get
			{
				return this._parameter;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._parameter = value;
			}
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x001CA3AD File Offset: 0x001C85AD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x001CA3B9 File Offset: 0x001C85B9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.DataType != null)
			{
				this.DataType.Accept(visitor);
			}
			if (this.Parameter != null)
			{
				this.Parameter.Accept(visitor);
			}
		}

		// Token: 0x04001DFB RID: 7675
		private DataTypeReference _dataType;

		// Token: 0x04001DFC RID: 7676
		private ScalarExpression _parameter;
	}
}
