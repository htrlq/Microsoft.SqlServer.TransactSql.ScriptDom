using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200022A RID: 554
	[Serializable]
	public class ConvertCall : PrimaryExpression
	{
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06002B97 RID: 11159 RVA: 0x001CA058 File Offset: 0x001C8258
		// (set) Token: 0x06002B98 RID: 11160 RVA: 0x001CA060 File Offset: 0x001C8260
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

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06002B99 RID: 11161 RVA: 0x001CA070 File Offset: 0x001C8270
		// (set) Token: 0x06002B9A RID: 11162 RVA: 0x001CA078 File Offset: 0x001C8278
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

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x001CA088 File Offset: 0x001C8288
		// (set) Token: 0x06002B9C RID: 11164 RVA: 0x001CA090 File Offset: 0x001C8290
		public ScalarExpression Style
		{
			get
			{
				return this._style;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._style = value;
			}
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x001CA0A0 File Offset: 0x001C82A0
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x001CA0AC File Offset: 0x001C82AC
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
			if (this.Style != null)
			{
				this.Style.Accept(visitor);
			}
		}

		// Token: 0x04001DED RID: 7661
		private DataTypeReference _dataType;

		// Token: 0x04001DEE RID: 7662
		private ScalarExpression _parameter;

		// Token: 0x04001DEF RID: 7663
		private ScalarExpression _style;
	}
}
