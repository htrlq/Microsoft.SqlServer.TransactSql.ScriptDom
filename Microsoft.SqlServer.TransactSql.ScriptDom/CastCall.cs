using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200022E RID: 558
	[Serializable]
	public class CastCall : PrimaryExpression
	{
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x001CA308 File Offset: 0x001C8508
		// (set) Token: 0x06002BBC RID: 11196 RVA: 0x001CA310 File Offset: 0x001C8510
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

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06002BBD RID: 11197 RVA: 0x001CA320 File Offset: 0x001C8520
		// (set) Token: 0x06002BBE RID: 11198 RVA: 0x001CA328 File Offset: 0x001C8528
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

		// Token: 0x06002BBF RID: 11199 RVA: 0x001CA338 File Offset: 0x001C8538
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x001CA344 File Offset: 0x001C8544
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

		// Token: 0x04001DF9 RID: 7673
		private DataTypeReference _dataType;

		// Token: 0x04001DFA RID: 7674
		private ScalarExpression _parameter;
	}
}
