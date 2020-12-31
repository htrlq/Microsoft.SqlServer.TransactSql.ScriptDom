using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002B1 RID: 689
	[Serializable]
	public class AlterTableSwitchStatement : AlterTableStatement
	{
		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06002EB0 RID: 11952 RVA: 0x001CD5EE File Offset: 0x001CB7EE
		// (set) Token: 0x06002EB1 RID: 11953 RVA: 0x001CD5F6 File Offset: 0x001CB7F6
		public ScalarExpression SourcePartitionNumber
		{
			get
			{
				return this._sourcePartitionNumber;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._sourcePartitionNumber = value;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06002EB2 RID: 11954 RVA: 0x001CD606 File Offset: 0x001CB806
		// (set) Token: 0x06002EB3 RID: 11955 RVA: 0x001CD60E File Offset: 0x001CB80E
		public ScalarExpression TargetPartitionNumber
		{
			get
			{
				return this._targetPartitionNumber;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._targetPartitionNumber = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06002EB4 RID: 11956 RVA: 0x001CD61E File Offset: 0x001CB81E
		// (set) Token: 0x06002EB5 RID: 11957 RVA: 0x001CD626 File Offset: 0x001CB826
		public SchemaObjectName TargetTable
		{
			get
			{
				return this._targetTable;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._targetTable = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06002EB6 RID: 11958 RVA: 0x001CD636 File Offset: 0x001CB836
		public IList<TableSwitchOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x001CD63E File Offset: 0x001CB83E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x001CD64C File Offset: 0x001CB84C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.SchemaObjectName != null)
			{
				base.SchemaObjectName.Accept(visitor);
			}
			if (this.SourcePartitionNumber != null)
			{
				this.SourcePartitionNumber.Accept(visitor);
			}
			if (this.TargetPartitionNumber != null)
			{
				this.TargetPartitionNumber.Accept(visitor);
			}
			if (this.TargetTable != null)
			{
				this.TargetTable.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001EC7 RID: 7879
		private ScalarExpression _sourcePartitionNumber;

		// Token: 0x04001EC8 RID: 7880
		private ScalarExpression _targetPartitionNumber;

		// Token: 0x04001EC9 RID: 7881
		private SchemaObjectName _targetTable;

		// Token: 0x04001ECA RID: 7882
		private List<TableSwitchOption> _options = new List<TableSwitchOption>();
	}
}
