using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200042A RID: 1066
	[Serializable]
	public class AddSearchPropertyListAction : SearchPropertyListAction
	{
		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060037C7 RID: 14279 RVA: 0x001D6BCA File Offset: 0x001D4DCA
		// (set) Token: 0x060037C8 RID: 14280 RVA: 0x001D6BD2 File Offset: 0x001D4DD2
		public StringLiteral PropertyName
		{
			get
			{
				return this._propertyName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._propertyName = value;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060037C9 RID: 14281 RVA: 0x001D6BE2 File Offset: 0x001D4DE2
		// (set) Token: 0x060037CA RID: 14282 RVA: 0x001D6BEA File Offset: 0x001D4DEA
		public StringLiteral Guid
		{
			get
			{
				return this._guid;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._guid = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060037CB RID: 14283 RVA: 0x001D6BFA File Offset: 0x001D4DFA
		// (set) Token: 0x060037CC RID: 14284 RVA: 0x001D6C02 File Offset: 0x001D4E02
		public IntegerLiteral Id
		{
			get
			{
				return this._id;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._id = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060037CD RID: 14285 RVA: 0x001D6C12 File Offset: 0x001D4E12
		// (set) Token: 0x060037CE RID: 14286 RVA: 0x001D6C1A File Offset: 0x001D4E1A
		public StringLiteral Description
		{
			get
			{
				return this._description;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._description = value;
			}
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x001D6C2A File Offset: 0x001D4E2A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x001D6C38 File Offset: 0x001D4E38
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.PropertyName != null)
			{
				this.PropertyName.Accept(visitor);
			}
			if (this.Guid != null)
			{
				this.Guid.Accept(visitor);
			}
			if (this.Id != null)
			{
				this.Id.Accept(visitor);
			}
			if (this.Description != null)
			{
				this.Description.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002166 RID: 8550
		private StringLiteral _propertyName;

		// Token: 0x04002167 RID: 8551
		private StringLiteral _guid;

		// Token: 0x04002168 RID: 8552
		private IntegerLiteral _id;

		// Token: 0x04002169 RID: 8553
		private StringLiteral _description;
	}
}
