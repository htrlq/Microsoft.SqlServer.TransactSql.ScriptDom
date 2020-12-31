using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003D7 RID: 983
	[Serializable]
	public abstract class AlterCreateServiceStatementBase : TSqlStatement
	{
		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060035DC RID: 13788 RVA: 0x001D4BAF File Offset: 0x001D2DAF
		// (set) Token: 0x060035DD RID: 13789 RVA: 0x001D4BB7 File Offset: 0x001D2DB7
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

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060035DE RID: 13790 RVA: 0x001D4BC7 File Offset: 0x001D2DC7
		// (set) Token: 0x060035DF RID: 13791 RVA: 0x001D4BCF File Offset: 0x001D2DCF
		public SchemaObjectName QueueName
		{
			get
			{
				return this._queueName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._queueName = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060035E0 RID: 13792 RVA: 0x001D4BDF File Offset: 0x001D2DDF
		public IList<ServiceContract> ServiceContracts
		{
			get
			{
				return this._serviceContracts;
			}
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x001D4BE8 File Offset: 0x001D2DE8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.QueueName != null)
			{
				this.QueueName.Accept(visitor);
			}
			int i = 0;
			int count = this.ServiceContracts.Count;
			while (i < count)
			{
				this.ServiceContracts[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020DE RID: 8414
		private Identifier _name;

		// Token: 0x040020DF RID: 8415
		private SchemaObjectName _queueName;

		// Token: 0x040020E0 RID: 8416
		private List<ServiceContract> _serviceContracts = new List<ServiceContract>();
	}
}
