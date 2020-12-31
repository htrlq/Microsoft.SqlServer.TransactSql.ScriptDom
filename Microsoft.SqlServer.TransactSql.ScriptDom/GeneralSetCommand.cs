using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200033D RID: 829
	[Serializable]
	public class GeneralSetCommand : SetCommand
	{
		// Token: 0x17000375 RID: 885
		// (get) Token: 0x060031D4 RID: 12756 RVA: 0x001D0A20 File Offset: 0x001CEC20
		// (set) Token: 0x060031D5 RID: 12757 RVA: 0x001D0A28 File Offset: 0x001CEC28
		public GeneralSetCommandType CommandType
		{
			get
			{
				return this._commandType;
			}
			set
			{
				this._commandType = value;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x060031D6 RID: 12758 RVA: 0x001D0A31 File Offset: 0x001CEC31
		// (set) Token: 0x060031D7 RID: 12759 RVA: 0x001D0A39 File Offset: 0x001CEC39
		public ScalarExpression Parameter
		{
			get
			{
				return this._parameter;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._parameter = value;
			}
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x001D0A49 File Offset: 0x001CEC49
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x001D0A55 File Offset: 0x001CEC55
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Parameter != null)
			{
				this.Parameter.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FA3 RID: 8099
		private GeneralSetCommandType _commandType;

		// Token: 0x04001FA4 RID: 8100
		private ScalarExpression _parameter;
	}
}
