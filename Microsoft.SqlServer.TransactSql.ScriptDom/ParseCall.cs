using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200022C RID: 556
	[Serializable]
	public class ParseCall : PrimaryExpression
	{
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x001CA1B0 File Offset: 0x001C83B0
		// (set) Token: 0x06002BAA RID: 11178 RVA: 0x001CA1B8 File Offset: 0x001C83B8
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

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06002BAB RID: 11179 RVA: 0x001CA1C8 File Offset: 0x001C83C8
		// (set) Token: 0x06002BAC RID: 11180 RVA: 0x001CA1D0 File Offset: 0x001C83D0
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

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06002BAD RID: 11181 RVA: 0x001CA1E0 File Offset: 0x001C83E0
		// (set) Token: 0x06002BAE RID: 11182 RVA: 0x001CA1E8 File Offset: 0x001C83E8
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

		// Token: 0x06002BAF RID: 11183 RVA: 0x001CA1F8 File Offset: 0x001C83F8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x001CA204 File Offset: 0x001C8404
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

		// Token: 0x04001DF3 RID: 7667
		private ScalarExpression _stringValue;

		// Token: 0x04001DF4 RID: 7668
		private DataTypeReference _dataType;

		// Token: 0x04001DF5 RID: 7669
		private ScalarExpression _culture;
	}
}
