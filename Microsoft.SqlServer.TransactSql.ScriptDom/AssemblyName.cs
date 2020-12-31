using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002A1 RID: 673
	[Serializable]
	public class AssemblyName : TSqlFragment
	{
		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x001CD0C4 File Offset: 0x001CB2C4
		// (set) Token: 0x06002E58 RID: 11864 RVA: 0x001CD0CC File Offset: 0x001CB2CC
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

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06002E59 RID: 11865 RVA: 0x001CD0DC File Offset: 0x001CB2DC
		// (set) Token: 0x06002E5A RID: 11866 RVA: 0x001CD0E4 File Offset: 0x001CB2E4
		public Identifier ClassName
		{
			get
			{
				return this._className;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._className = value;
			}
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x001CD0F4 File Offset: 0x001CB2F4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x001CD100 File Offset: 0x001CB300
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.ClassName != null)
			{
				this.ClassName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EB0 RID: 7856
		private Identifier _name;

		// Token: 0x04001EB1 RID: 7857
		private Identifier _className;
	}
}
