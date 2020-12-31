using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002EB RID: 747
	[Serializable]
	public abstract class MasterKeyStatement : TSqlStatement
	{
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x0600302C RID: 12332 RVA: 0x001CF07F File Offset: 0x001CD27F
		// (set) Token: 0x0600302D RID: 12333 RVA: 0x001CF087 File Offset: 0x001CD287
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

		// Token: 0x0600302E RID: 12334 RVA: 0x001CF097 File Offset: 0x001CD297
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Password != null)
			{
				this.Password.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F3D RID: 7997
		private Literal _password;
	}
}
