using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000437 RID: 1079
	[Serializable]
	public class PasswordAlterPrincipalOption : PrincipalOption
	{
		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06003813 RID: 14355 RVA: 0x001D7083 File Offset: 0x001D5283
		// (set) Token: 0x06003814 RID: 14356 RVA: 0x001D708B File Offset: 0x001D528B
		public Literal Password
		{
			get
			{
				return this._password;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._password = value;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06003815 RID: 14357 RVA: 0x001D709B File Offset: 0x001D529B
		// (set) Token: 0x06003816 RID: 14358 RVA: 0x001D70A3 File Offset: 0x001D52A3
		public Literal OldPassword
		{
			get
			{
				return this._oldPassword;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._oldPassword = value;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06003817 RID: 14359 RVA: 0x001D70B3 File Offset: 0x001D52B3
		// (set) Token: 0x06003818 RID: 14360 RVA: 0x001D70BB File Offset: 0x001D52BB
		public bool MustChange
		{
			get
			{
				return this._mustChange;
			}
			set
			{
				this._mustChange = value;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06003819 RID: 14361 RVA: 0x001D70C4 File Offset: 0x001D52C4
		// (set) Token: 0x0600381A RID: 14362 RVA: 0x001D70CC File Offset: 0x001D52CC
		public bool Unlock
		{
			get
			{
				return this._unlock;
			}
			set
			{
				this._unlock = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x0600381B RID: 14363 RVA: 0x001D70D5 File Offset: 0x001D52D5
		// (set) Token: 0x0600381C RID: 14364 RVA: 0x001D70DD File Offset: 0x001D52DD
		public bool Hashed
		{
			get
			{
				return this._hashed;
			}
			set
			{
				this._hashed = value;
			}
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x001D70E6 File Offset: 0x001D52E6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x001D70F2 File Offset: 0x001D52F2
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Password != null)
			{
				this.Password.Accept(visitor);
			}
			if (this.OldPassword != null)
			{
				this.OldPassword.Accept(visitor);
			}
		}

		// Token: 0x0400217A RID: 8570
		private Literal _password;

		// Token: 0x0400217B RID: 8571
		private Literal _oldPassword;

		// Token: 0x0400217C RID: 8572
		private bool _mustChange;

		// Token: 0x0400217D RID: 8573
		private bool _unlock;

		// Token: 0x0400217E RID: 8574
		private bool _hashed;
	}
}
