using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000209 RID: 521
	[Serializable]
	public class UserDefinedTypePropertyAccess : PrimaryExpression
	{
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06002ABB RID: 10939 RVA: 0x001C8F89 File Offset: 0x001C7189
		// (set) Token: 0x06002ABC RID: 10940 RVA: 0x001C8F91 File Offset: 0x001C7191
		public CallTarget CallTarget
		{
			get
			{
				return this._callTarget;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._callTarget = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x001C8FA1 File Offset: 0x001C71A1
		// (set) Token: 0x06002ABE RID: 10942 RVA: 0x001C8FA9 File Offset: 0x001C71A9
		public Identifier PropertyName
		{
			get
			{
				return this._propertyName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._propertyName = value;
			}
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x001C8FB9 File Offset: 0x001C71B9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x001C8FC5 File Offset: 0x001C71C5
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.CallTarget != null)
			{
				this.CallTarget.Accept(visitor);
			}
			if (this.PropertyName != null)
			{
				this.PropertyName.Accept(visitor);
			}
		}

		// Token: 0x04001DA7 RID: 7591
		private CallTarget _callTarget;

		// Token: 0x04001DA8 RID: 7592
		private Identifier _propertyName;
	}
}
