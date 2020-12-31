using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004AD RID: 1197
	[Serializable]
	public class EventDeclarationCompareFunctionParameter : BooleanExpression
	{
		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06003AA6 RID: 15014 RVA: 0x001D982C File Offset: 0x001D7A2C
		// (set) Token: 0x06003AA7 RID: 15015 RVA: 0x001D9834 File Offset: 0x001D7A34
		public EventSessionObjectName Name
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

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06003AA8 RID: 15016 RVA: 0x001D9844 File Offset: 0x001D7A44
		// (set) Token: 0x06003AA9 RID: 15017 RVA: 0x001D984C File Offset: 0x001D7A4C
		public SourceDeclaration SourceDeclaration
		{
			get
			{
				return this._sourceDeclaration;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._sourceDeclaration = value;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06003AAA RID: 15018 RVA: 0x001D985C File Offset: 0x001D7A5C
		// (set) Token: 0x06003AAB RID: 15019 RVA: 0x001D9864 File Offset: 0x001D7A64
		public ScalarExpression EventValue
		{
			get
			{
				return this._eventValue;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._eventValue = value;
			}
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x001D9874 File Offset: 0x001D7A74
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x001D9880 File Offset: 0x001D7A80
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.SourceDeclaration != null)
			{
				this.SourceDeclaration.Accept(visitor);
			}
			if (this.EventValue != null)
			{
				this.EventValue.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002227 RID: 8743
		private EventSessionObjectName _name;

		// Token: 0x04002228 RID: 8744
		private SourceDeclaration _sourceDeclaration;

		// Token: 0x04002229 RID: 8745
		private ScalarExpression _eventValue;
	}
}
