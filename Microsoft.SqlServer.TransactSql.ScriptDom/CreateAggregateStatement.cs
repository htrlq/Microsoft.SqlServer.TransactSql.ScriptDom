using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003B1 RID: 945
	[Serializable]
	public class CreateAggregateStatement : TSqlStatement
	{
		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060034E9 RID: 13545 RVA: 0x001D3CAF File Offset: 0x001D1EAF
		// (set) Token: 0x060034EA RID: 13546 RVA: 0x001D3CB7 File Offset: 0x001D1EB7
		public SchemaObjectName Name
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

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060034EB RID: 13547 RVA: 0x001D3CC7 File Offset: 0x001D1EC7
		// (set) Token: 0x060034EC RID: 13548 RVA: 0x001D3CCF File Offset: 0x001D1ECF
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

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060034ED RID: 13549 RVA: 0x001D3CDF File Offset: 0x001D1EDF
		public IList<ProcedureParameter> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060034EE RID: 13550 RVA: 0x001D3CE7 File Offset: 0x001D1EE7
		// (set) Token: 0x060034EF RID: 13551 RVA: 0x001D3CEF File Offset: 0x001D1EEF
		public DataTypeReference ReturnType
		{
			get
			{
				return this._returnType;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._returnType = value;
			}
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x001D3CFF File Offset: 0x001D1EFF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x001D3D0C File Offset: 0x001D1F0C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.AssemblyName != null)
			{
				this.AssemblyName.Accept(visitor);
			}
			int i = 0;
			int count = this.Parameters.Count;
			while (i < count)
			{
				this.Parameters[i].Accept(visitor);
				i++;
			}
			if (this.ReturnType != null)
			{
				this.ReturnType.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002097 RID: 8343
		private SchemaObjectName _name;

		// Token: 0x04002098 RID: 8344
		private AssemblyName _assemblyName;

		// Token: 0x04002099 RID: 8345
		private List<ProcedureParameter> _parameters = new List<ProcedureParameter>();

		// Token: 0x0400209A RID: 8346
		private DataTypeReference _returnType;
	}
}
