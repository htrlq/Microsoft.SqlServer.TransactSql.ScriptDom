using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004B7 RID: 1207
	[Serializable]
	public class AlterResourceGovernorStatement : TSqlStatement
	{
		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06003AE0 RID: 15072 RVA: 0x001D9B7F File Offset: 0x001D7D7F
		// (set) Token: 0x06003AE1 RID: 15073 RVA: 0x001D9B87 File Offset: 0x001D7D87
		public AlterResourceGovernorCommandType Command
		{
			get
			{
				return this._command;
			}
			set
			{
				this._command = value;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06003AE2 RID: 15074 RVA: 0x001D9B90 File Offset: 0x001D7D90
		// (set) Token: 0x06003AE3 RID: 15075 RVA: 0x001D9B98 File Offset: 0x001D7D98
		public SchemaObjectName ClassifierFunction
		{
			get
			{
				return this._classifierFunction;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._classifierFunction = value;
			}
		}

		// Token: 0x06003AE4 RID: 15076 RVA: 0x001D9BA8 File Offset: 0x001D7DA8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x001D9BB4 File Offset: 0x001D7DB4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ClassifierFunction != null)
			{
				this.ClassifierFunction.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002237 RID: 8759
		private AlterResourceGovernorCommandType _command;

		// Token: 0x04002238 RID: 8760
		private SchemaObjectName _classifierFunction;
	}
}
