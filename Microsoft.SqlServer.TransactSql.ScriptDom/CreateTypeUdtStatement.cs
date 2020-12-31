using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002BE RID: 702
	[Serializable]
	public class CreateTypeUdtStatement : CreateTypeStatement
	{
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06002EFE RID: 12030 RVA: 0x001CDB5F File Offset: 0x001CBD5F
		// (set) Token: 0x06002EFF RID: 12031 RVA: 0x001CDB67 File Offset: 0x001CBD67
		public AssemblyName AssemblyName
		{
			get
			{
				return this._assemblyName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._assemblyName = value;
			}
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x001CDB77 File Offset: 0x001CBD77
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x001CDB83 File Offset: 0x001CBD83
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			if (this.AssemblyName != null)
			{
				this.AssemblyName.Accept(visitor);
			}
		}

		// Token: 0x04001EDF RID: 7903
		private AssemblyName _assemblyName;
	}
}
