using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001E1 RID: 481
	[Serializable]
	public class MethodSpecifier : TSqlFragment
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x001C7F9A File Offset: 0x001C619A
		// (set) Token: 0x060029D8 RID: 10712 RVA: 0x001C7FA2 File Offset: 0x001C61A2
		public Identifier AssemblyName
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

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x001C7FB2 File Offset: 0x001C61B2
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x001C7FBA File Offset: 0x001C61BA
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x001C7FCA File Offset: 0x001C61CA
		// (set) Token: 0x060029DC RID: 10716 RVA: 0x001C7FD2 File Offset: 0x001C61D2
		public Identifier MethodName
		{
			get
			{
				return this._methodName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._methodName = value;
			}
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x001C7FE2 File Offset: 0x001C61E2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x001C7FF0 File Offset: 0x001C61F0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.AssemblyName != null)
			{
				this.AssemblyName.Accept(visitor);
			}
			if (this.ClassName != null)
			{
				this.ClassName.Accept(visitor);
			}
			if (this.MethodName != null)
			{
				this.MethodName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D65 RID: 7525
		private Identifier _assemblyName;

		// Token: 0x04001D66 RID: 7526
		private Identifier _className;

		// Token: 0x04001D67 RID: 7527
		private Identifier _methodName;
	}
}
