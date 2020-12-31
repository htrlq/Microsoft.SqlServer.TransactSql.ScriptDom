using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004CD RID: 1229
	[Serializable]
	public abstract class AvailabilityGroupStatement : TSqlStatement
	{
		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06003B5C RID: 15196 RVA: 0x001DA374 File Offset: 0x001D8574
		// (set) Token: 0x06003B5D RID: 15197 RVA: 0x001DA37C File Offset: 0x001D857C
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

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06003B5E RID: 15198 RVA: 0x001DA38C File Offset: 0x001D858C
		public IList<AvailabilityGroupOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06003B5F RID: 15199 RVA: 0x001DA394 File Offset: 0x001D8594
		public IList<Identifier> Databases
		{
			get
			{
				return this._databases;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06003B60 RID: 15200 RVA: 0x001DA39C File Offset: 0x001D859C
		public IList<AvailabilityReplica> Replicas
		{
			get
			{
				return this._replicas;
			}
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x001DA3A4 File Offset: 0x001D85A4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.Databases.Count;
			while (j < count2)
			{
				this.Databases[j].Accept(visitor);
				j++;
			}
			int k = 0;
			int count3 = this.Replicas.Count;
			while (k < count3)
			{
				this.Replicas[k].Accept(visitor);
				k++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002259 RID: 8793
		private Identifier _name;

		// Token: 0x0400225A RID: 8794
		private List<AvailabilityGroupOption> _options = new List<AvailabilityGroupOption>();

		// Token: 0x0400225B RID: 8795
		private List<Identifier> _databases = new List<Identifier>();

		// Token: 0x0400225C RID: 8796
		private List<AvailabilityReplica> _replicas = new List<AvailabilityReplica>();
	}
}
