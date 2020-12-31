using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004AA RID: 1194
	[Serializable]
	public class EventDeclaration : TSqlFragment
	{
		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06003A91 RID: 14993 RVA: 0x001D9673 File Offset: 0x001D7873
		// (set) Token: 0x06003A92 RID: 14994 RVA: 0x001D967B File Offset: 0x001D787B
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

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06003A93 RID: 14995 RVA: 0x001D968B File Offset: 0x001D788B
		public IList<EventDeclarationSetParameter> EventDeclarationSetParameters
		{
			get
			{
				return this._eventDeclarationSetParameters;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06003A94 RID: 14996 RVA: 0x001D9693 File Offset: 0x001D7893
		public IList<EventSessionObjectName> EventDeclarationActionParameters
		{
			get
			{
				return this._eventDeclarationActionParameters;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06003A95 RID: 14997 RVA: 0x001D969B File Offset: 0x001D789B
		// (set) Token: 0x06003A96 RID: 14998 RVA: 0x001D96A3 File Offset: 0x001D78A3
		public BooleanExpression EventDeclarationPredicateParameter
		{
			get
			{
				return this._eventDeclarationPredicateParameter;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._eventDeclarationPredicateParameter = value;
			}
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x001D96B3 File Offset: 0x001D78B3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x001D96C0 File Offset: 0x001D78C0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ObjectName != null)
			{
				this.ObjectName.Accept(visitor);
			}
			int i = 0;
			int count = this.EventDeclarationSetParameters.Count;
			while (i < count)
			{
				this.EventDeclarationSetParameters[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.EventDeclarationActionParameters.Count;
			while (j < count2)
			{
				this.EventDeclarationActionParameters[j].Accept(visitor);
				j++;
			}
			if (this.EventDeclarationPredicateParameter != null)
			{
				this.EventDeclarationPredicateParameter.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002220 RID: 8736
		private EventSessionObjectName _objectName;

		// Token: 0x04002221 RID: 8737
		private List<EventDeclarationSetParameter> _eventDeclarationSetParameters = new List<EventDeclarationSetParameter>();

		// Token: 0x04002222 RID: 8738
		private List<EventSessionObjectName> _eventDeclarationActionParameters = new List<EventSessionObjectName>();

		// Token: 0x04002223 RID: 8739
		private BooleanExpression _eventDeclarationPredicateParameter;
	}
}
