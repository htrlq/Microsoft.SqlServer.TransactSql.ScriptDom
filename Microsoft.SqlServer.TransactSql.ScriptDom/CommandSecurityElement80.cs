using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000275 RID: 629
	[Serializable]
	public class CommandSecurityElement80 : SecurityElement80
	{
		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06002D6D RID: 11629 RVA: 0x001CC1BD File Offset: 0x001CA3BD
		// (set) Token: 0x06002D6E RID: 11630 RVA: 0x001CC1C5 File Offset: 0x001CA3C5
		public bool All
		{
			get
			{
				return this._all;
			}
			set
			{
				this._all = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06002D6F RID: 11631 RVA: 0x001CC1CE File Offset: 0x001CA3CE
		// (set) Token: 0x06002D70 RID: 11632 RVA: 0x001CC1D6 File Offset: 0x001CA3D6
		public CommandOptions CommandOptions
		{
			get
			{
				return this._commandOptions;
			}
			set
			{
				this._commandOptions = value;
			}
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x001CC1DF File Offset: 0x001CA3DF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x001CC1EB File Offset: 0x001CA3EB
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E74 RID: 7796
		private bool _all;

		// Token: 0x04001E75 RID: 7797
		private CommandOptions _commandOptions;
	}
}
