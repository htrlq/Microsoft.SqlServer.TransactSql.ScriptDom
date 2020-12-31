using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200032D RID: 813
	[Serializable]
	public class ThrowStatement : TSqlStatement
	{
		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600317E RID: 12670 RVA: 0x001D05DD File Offset: 0x001CE7DD
		// (set) Token: 0x0600317F RID: 12671 RVA: 0x001D05E5 File Offset: 0x001CE7E5
		public ValueExpression ErrorNumber
		{
			get
			{
				return this._errorNumber;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._errorNumber = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06003180 RID: 12672 RVA: 0x001D05F5 File Offset: 0x001CE7F5
		// (set) Token: 0x06003181 RID: 12673 RVA: 0x001D05FD File Offset: 0x001CE7FD
		public ValueExpression Message
		{
			get
			{
				return this._message;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._message = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06003182 RID: 12674 RVA: 0x001D060D File Offset: 0x001CE80D
		// (set) Token: 0x06003183 RID: 12675 RVA: 0x001D0615 File Offset: 0x001CE815
		public ValueExpression State
		{
			get
			{
				return this._state;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._state = value;
			}
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x001D0625 File Offset: 0x001CE825
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x001D0634 File Offset: 0x001CE834
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ErrorNumber != null)
			{
				this.ErrorNumber.Accept(visitor);
			}
			if (this.Message != null)
			{
				this.Message.Accept(visitor);
			}
			if (this.State != null)
			{
				this.State.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F8F RID: 8079
		private ValueExpression _errorNumber;

		// Token: 0x04001F90 RID: 8080
		private ValueExpression _message;

		// Token: 0x04001F91 RID: 8081
		private ValueExpression _state;
	}
}
