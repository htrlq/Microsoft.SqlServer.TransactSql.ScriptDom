using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200022D RID: 557
	[Serializable]
	public class TryParseCall : PrimaryExpression
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x001CA25C File Offset: 0x001C845C
		// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x001CA264 File Offset: 0x001C8464
		public ScalarExpression StringValue
		{
			get
			{
				return this._stringValue;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._stringValue = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x001CA274 File Offset: 0x001C8474
		// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x001CA27C File Offset: 0x001C847C
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

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x001CA28C File Offset: 0x001C848C
		// (set) Token: 0x06002BB7 RID: 11191 RVA: 0x001CA294 File Offset: 0x001C8494
		public ScalarExpression Culture
		{
			get
			{
				return this._culture;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._culture = value;
			}
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x001CA2A4 File Offset: 0x001C84A4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x001CA2B0 File Offset: 0x001C84B0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.StringValue != null)
			{
				this.StringValue.Accept(visitor);
			}
			if (this.DataType != null)
			{
				this.DataType.Accept(visitor);
			}
			if (this.Culture != null)
			{
				this.Culture.Accept(visitor);
			}
		}

		// Token: 0x04001DF6 RID: 7670
		private ScalarExpression _stringValue;

		// Token: 0x04001DF7 RID: 7671
		private DataTypeReference _dataType;

		// Token: 0x04001DF8 RID: 7672
		private ScalarExpression _culture;
	}
}
