using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000206 RID: 518
	[Serializable]
	public class LikePredicate : BooleanExpression
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06002A98 RID: 10904 RVA: 0x001C8CEE File Offset: 0x001C6EEE
		// (set) Token: 0x06002A99 RID: 10905 RVA: 0x001C8CF6 File Offset: 0x001C6EF6
		public ScalarExpression FirstExpression
		{
			get
			{
				return this._firstExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._firstExpression = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06002A9A RID: 10906 RVA: 0x001C8D06 File Offset: 0x001C6F06
		// (set) Token: 0x06002A9B RID: 10907 RVA: 0x001C8D0E File Offset: 0x001C6F0E
		public ScalarExpression SecondExpression
		{
			get
			{
				return this._secondExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._secondExpression = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x001C8D1E File Offset: 0x001C6F1E
		// (set) Token: 0x06002A9D RID: 10909 RVA: 0x001C8D26 File Offset: 0x001C6F26
		public bool NotDefined
		{
			get
			{
				return this._notDefined;
			}
			set
			{
				this._notDefined = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06002A9E RID: 10910 RVA: 0x001C8D2F File Offset: 0x001C6F2F
		// (set) Token: 0x06002A9F RID: 10911 RVA: 0x001C8D37 File Offset: 0x001C6F37
		public bool OdbcEscape
		{
			get
			{
				return this._odbcEscape;
			}
			set
			{
				this._odbcEscape = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x001C8D40 File Offset: 0x001C6F40
		// (set) Token: 0x06002AA1 RID: 10913 RVA: 0x001C8D48 File Offset: 0x001C6F48
		public ScalarExpression EscapeExpression
		{
			get
			{
				return this._escapeExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._escapeExpression = value;
			}
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x001C8D58 File Offset: 0x001C6F58
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x001C8D64 File Offset: 0x001C6F64
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.FirstExpression != null)
			{
				this.FirstExpression.Accept(visitor);
			}
			if (this.SecondExpression != null)
			{
				this.SecondExpression.Accept(visitor);
			}
			if (this.EscapeExpression != null)
			{
				this.EscapeExpression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D99 RID: 7577
		private ScalarExpression _firstExpression;

		// Token: 0x04001D9A RID: 7578
		private ScalarExpression _secondExpression;

		// Token: 0x04001D9B RID: 7579
		private bool _notDefined;

		// Token: 0x04001D9C RID: 7580
		private bool _odbcEscape;

		// Token: 0x04001D9D RID: 7581
		private ScalarExpression _escapeExpression;
	}
}
