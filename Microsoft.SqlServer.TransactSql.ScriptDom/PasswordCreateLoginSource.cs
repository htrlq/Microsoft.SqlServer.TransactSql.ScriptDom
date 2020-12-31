using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200042F RID: 1071
	[Serializable]
	public class PasswordCreateLoginSource : CreateLoginSource
	{
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060037E3 RID: 14307 RVA: 0x001D6D90 File Offset: 0x001D4F90
		// (set) Token: 0x060037E4 RID: 14308 RVA: 0x001D6D98 File Offset: 0x001D4F98
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

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060037E5 RID: 14309 RVA: 0x001D6DA8 File Offset: 0x001D4FA8
		// (set) Token: 0x060037E6 RID: 14310 RVA: 0x001D6DB0 File Offset: 0x001D4FB0
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

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060037E7 RID: 14311 RVA: 0x001D6DB9 File Offset: 0x001D4FB9
		// (set) Token: 0x060037E8 RID: 14312 RVA: 0x001D6DC1 File Offset: 0x001D4FC1
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

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060037E9 RID: 14313 RVA: 0x001D6DCA File Offset: 0x001D4FCA
		public IList<PrincipalOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x001D6DD2 File Offset: 0x001D4FD2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x001D6DE0 File Offset: 0x001D4FE0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Password != null)
			{
				this.Password.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400216D RID: 8557
		private Literal _password;

		// Token: 0x0400216E RID: 8558
		private bool _hashed;

		// Token: 0x0400216F RID: 8559
		private bool _mustChange;

		// Token: 0x04002170 RID: 8560
		private List<PrincipalOption> _options = new List<PrincipalOption>();
	}
}
