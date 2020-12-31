using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001EE RID: 494
	[Serializable]
	public class TableValuedFunctionReturnType : FunctionReturnType
	{
		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x001C84AA File Offset: 0x001C66AA
		// (set) Token: 0x06002A20 RID: 10784 RVA: 0x001C84B2 File Offset: 0x001C66B2
		public DeclareTableVariableBody DeclareTableVariableBody
		{
			get
			{
				return this._declareTableVariableBody;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._declareTableVariableBody = value;
			}
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x001C84C2 File Offset: 0x001C66C2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x001C84CE File Offset: 0x001C66CE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.DeclareTableVariableBody != null)
			{
				this.DeclareTableVariableBody.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D79 RID: 7545
		private DeclareTableVariableBody _declareTableVariableBody;
	}
}
