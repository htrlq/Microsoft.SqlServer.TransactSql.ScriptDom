using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001F7 RID: 503
	[Serializable]
	public class DeclareTableVariableBody : TSqlFragment
	{
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06002A4A RID: 10826 RVA: 0x001C87A6 File Offset: 0x001C69A6
		// (set) Token: 0x06002A4B RID: 10827 RVA: 0x001C87AE File Offset: 0x001C69AE
		public Identifier VariableName
		{
			get
			{
				return this._variableName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._variableName = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x001C87BE File Offset: 0x001C69BE
		// (set) Token: 0x06002A4D RID: 10829 RVA: 0x001C87C6 File Offset: 0x001C69C6
		public bool AsDefined
		{
			get
			{
				return this._asDefined;
			}
			set
			{
				this._asDefined = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06002A4E RID: 10830 RVA: 0x001C87CF File Offset: 0x001C69CF
		// (set) Token: 0x06002A4F RID: 10831 RVA: 0x001C87D7 File Offset: 0x001C69D7
		public TableDefinition Definition
		{
			get
			{
				return this._definition;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._definition = value;
			}
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x001C87E7 File Offset: 0x001C69E7
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x001C87F3 File Offset: 0x001C69F3
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.VariableName != null)
			{
				this.VariableName.Accept(visitor);
			}
			if (this.Definition != null)
			{
				this.Definition.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D84 RID: 7556
		private Identifier _variableName;

		// Token: 0x04001D85 RID: 7557
		private bool _asDefined;

		// Token: 0x04001D86 RID: 7558
		private TableDefinition _definition;
	}
}
