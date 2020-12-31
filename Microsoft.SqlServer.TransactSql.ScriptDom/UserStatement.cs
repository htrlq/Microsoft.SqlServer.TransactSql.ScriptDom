using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002FE RID: 766
	[Serializable]
	public abstract class UserStatement : TSqlStatement
	{
		// Token: 0x1700031E RID: 798
		// (get) Token: 0x0600307D RID: 12413 RVA: 0x001CF4CC File Offset: 0x001CD6CC
		// (set) Token: 0x0600307E RID: 12414 RVA: 0x001CF4D4 File Offset: 0x001CD6D4
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600307F RID: 12415 RVA: 0x001CF4E4 File Offset: 0x001CD6E4
		public IList<PrincipalOption> UserOptions
		{
			get
			{
				return this._userOptions;
			}
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x001CF4EC File Offset: 0x001CD6EC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.UserOptions.Count;
			while (i < count)
			{
				this.UserOptions[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F4C RID: 8012
		private Identifier _name;

		// Token: 0x04001F4D RID: 8013
		private List<PrincipalOption> _userOptions = new List<PrincipalOption>();
	}
}
