using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004AE RID: 1198
	[Serializable]
	public class TargetDeclaration : TSqlFragment
	{
		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06003AAF RID: 15023 RVA: 0x001D98D8 File Offset: 0x001D7AD8
		// (set) Token: 0x06003AB0 RID: 15024 RVA: 0x001D98E0 File Offset: 0x001D7AE0
		public EventSessionObjectName ObjectName
		{
			get
			{
				return this._objectName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._objectName = value;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06003AB1 RID: 15025 RVA: 0x001D98F0 File Offset: 0x001D7AF0
		public IList<EventDeclarationSetParameter> TargetDeclarationParameters
		{
			get
			{
				return this._targetDeclarationParameters;
			}
		}

		// Token: 0x06003AB2 RID: 15026 RVA: 0x001D98F8 File Offset: 0x001D7AF8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x001D9904 File Offset: 0x001D7B04
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ObjectName != null)
			{
				this.ObjectName.Accept(visitor);
			}
			int i = 0;
			int count = this.TargetDeclarationParameters.Count;
			while (i < count)
			{
				this.TargetDeclarationParameters[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400222A RID: 8746
		private EventSessionObjectName _objectName;

		// Token: 0x0400222B RID: 8747
		private List<EventDeclarationSetParameter> _targetDeclarationParameters = new List<EventDeclarationSetParameter>();
	}
}
