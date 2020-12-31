using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000404 RID: 1028
	[Serializable]
	public class ChangeTableVersionTableReference : TableReferenceWithAliasAndColumns
	{
		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060036F8 RID: 14072 RVA: 0x001D600C File Offset: 0x001D420C
		// (set) Token: 0x060036F9 RID: 14073 RVA: 0x001D6014 File Offset: 0x001D4214
		public SchemaObjectName Target
		{
			get
			{
				return this._target;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._target = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060036FA RID: 14074 RVA: 0x001D6024 File Offset: 0x001D4224
		public IList<Identifier> PrimaryKeyColumns
		{
			get
			{
				return this._primaryKeyColumns;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060036FB RID: 14075 RVA: 0x001D602C File Offset: 0x001D422C
		public IList<ScalarExpression> PrimaryKeyValues
		{
			get
			{
				return this._primaryKeyValues;
			}
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x001D6034 File Offset: 0x001D4234
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x001D6040 File Offset: 0x001D4240
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Target != null)
			{
				this.Target.Accept(visitor);
			}
			int i = 0;
			int count = this.PrimaryKeyColumns.Count;
			while (i < count)
			{
				this.PrimaryKeyColumns[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.PrimaryKeyValues.Count;
			while (j < count2)
			{
				this.PrimaryKeyValues[j].Accept(visitor);
				j++;
			}
		}

		// Token: 0x04002134 RID: 8500
		private SchemaObjectName _target;

		// Token: 0x04002135 RID: 8501
		private List<Identifier> _primaryKeyColumns = new List<Identifier>();

		// Token: 0x04002136 RID: 8502
		private List<ScalarExpression> _primaryKeyValues = new List<ScalarExpression>();
	}
}
