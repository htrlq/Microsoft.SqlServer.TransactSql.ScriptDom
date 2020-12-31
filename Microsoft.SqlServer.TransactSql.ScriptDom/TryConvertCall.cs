using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200022B RID: 555
	[Serializable]
	public class TryConvertCall : PrimaryExpression
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06002BA0 RID: 11168 RVA: 0x001CA104 File Offset: 0x001C8304
		// (set) Token: 0x06002BA1 RID: 11169 RVA: 0x001CA10C File Offset: 0x001C830C
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

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x001CA11C File Offset: 0x001C831C
		// (set) Token: 0x06002BA3 RID: 11171 RVA: 0x001CA124 File Offset: 0x001C8324
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

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x001CA134 File Offset: 0x001C8334
		// (set) Token: 0x06002BA5 RID: 11173 RVA: 0x001CA13C File Offset: 0x001C833C
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

		// Token: 0x06002BA6 RID: 11174 RVA: 0x001CA14C File Offset: 0x001C834C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x001CA158 File Offset: 0x001C8358
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

		// Token: 0x04001DF0 RID: 7664
		private DataTypeReference _dataType;

		// Token: 0x04001DF1 RID: 7665
		private ScalarExpression _parameter;

		// Token: 0x04001DF2 RID: 7666
		private ScalarExpression _style;
	}
}
