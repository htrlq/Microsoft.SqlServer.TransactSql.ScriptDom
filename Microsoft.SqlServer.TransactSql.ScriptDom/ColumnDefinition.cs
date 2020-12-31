using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000371 RID: 881
	[Serializable]
	public class ColumnDefinition : ColumnDefinitionBase
	{
		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06003327 RID: 13095 RVA: 0x001D1D50 File Offset: 0x001CFF50
		// (set) Token: 0x06003328 RID: 13096 RVA: 0x001D1D58 File Offset: 0x001CFF58
		public ScalarExpression ComputedColumnExpression
		{
			get
			{
				return this._computedColumnExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._computedColumnExpression = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06003329 RID: 13097 RVA: 0x001D1D68 File Offset: 0x001CFF68
		// (set) Token: 0x0600332A RID: 13098 RVA: 0x001D1D70 File Offset: 0x001CFF70
		public bool IsPersisted
		{
			get
			{
				return this._isPersisted;
			}
			set
			{
				this._isPersisted = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x001D1D79 File Offset: 0x001CFF79
		// (set) Token: 0x0600332C RID: 13100 RVA: 0x001D1D81 File Offset: 0x001CFF81
		public DefaultConstraintDefinition DefaultConstraint
		{
			get
			{
				return this._defaultConstraint;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._defaultConstraint = value;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x0600332D RID: 13101 RVA: 0x001D1D91 File Offset: 0x001CFF91
		// (set) Token: 0x0600332E RID: 13102 RVA: 0x001D1D99 File Offset: 0x001CFF99
		public IdentityOptions IdentityOptions
		{
			get
			{
				return this._identityOptions;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._identityOptions = value;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x0600332F RID: 13103 RVA: 0x001D1DA9 File Offset: 0x001CFFA9
		// (set) Token: 0x06003330 RID: 13104 RVA: 0x001D1DB1 File Offset: 0x001CFFB1
		public bool IsRowGuidCol
		{
			get
			{
				return this._isRowGuidCol;
			}
			set
			{
				this._isRowGuidCol = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06003331 RID: 13105 RVA: 0x001D1DBA File Offset: 0x001CFFBA
		public IList<ConstraintDefinition> Constraints
		{
			get
			{
				return this._constraints;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06003332 RID: 13106 RVA: 0x001D1DC2 File Offset: 0x001CFFC2
		// (set) Token: 0x06003333 RID: 13107 RVA: 0x001D1DCA File Offset: 0x001CFFCA
		public ColumnStorageOptions StorageOptions
		{
			get
			{
				return this._storageOptions;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._storageOptions = value;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06003334 RID: 13108 RVA: 0x001D1DDA File Offset: 0x001CFFDA
		// (set) Token: 0x06003335 RID: 13109 RVA: 0x001D1DE2 File Offset: 0x001CFFE2
		public IndexDefinition Index
		{
			get
			{
				return this._index;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._index = value;
			}
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x001D1DF2 File Offset: 0x001CFFF2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x001D1E00 File Offset: 0x001D0000
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.ComputedColumnExpression != null)
			{
				this.ComputedColumnExpression.Accept(visitor);
			}
			if (this.DefaultConstraint != null)
			{
				this.DefaultConstraint.Accept(visitor);
			}
			if (this.IdentityOptions != null)
			{
				this.IdentityOptions.Accept(visitor);
			}
			int i = 0;
			int count = this.Constraints.Count;
			while (i < count)
			{
				this.Constraints[i].Accept(visitor);
				i++;
			}
			if (this.StorageOptions != null)
			{
				this.StorageOptions.Accept(visitor);
			}
			if (this.Index != null)
			{
				this.Index.Accept(visitor);
			}
		}

		// Token: 0x04002004 RID: 8196
		private ScalarExpression _computedColumnExpression;

		// Token: 0x04002005 RID: 8197
		private bool _isPersisted;

		// Token: 0x04002006 RID: 8198
		private DefaultConstraintDefinition _defaultConstraint;

		// Token: 0x04002007 RID: 8199
		private IdentityOptions _identityOptions;

		// Token: 0x04002008 RID: 8200
		private bool _isRowGuidCol;

		// Token: 0x04002009 RID: 8201
		private List<ConstraintDefinition> _constraints = new List<ConstraintDefinition>();

		// Token: 0x0400200A RID: 8202
		private ColumnStorageOptions _storageOptions;

		// Token: 0x0400200B RID: 8203
		private IndexDefinition _index;
	}
}
