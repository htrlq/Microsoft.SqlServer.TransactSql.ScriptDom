using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200033F RID: 831
	[Serializable]
	public class SetCommandStatement : TSqlStatement
	{
		// Token: 0x17000378 RID: 888
		// (get) Token: 0x060031E0 RID: 12768 RVA: 0x001D0AA8 File Offset: 0x001CECA8
		public IList<SetCommand> Commands
		{
			get
			{
				return this._commands;
			}
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x001D0AB0 File Offset: 0x001CECB0
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x001D0ABC File Offset: 0x001CECBC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Commands.Count;
			while (i < count)
			{
				this.Commands[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FA6 RID: 8102
		private List<SetCommand> _commands = new List<SetCommand>();
	}
}
