using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000222 RID: 546
	[Serializable]
	public class SemanticTableReference : TableReferenceWithAlias
	{
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06002B4B RID: 11083 RVA: 0x001C9A35 File Offset: 0x001C7C35
		// (set) Token: 0x06002B4C RID: 11084 RVA: 0x001C9A3D File Offset: 0x001C7C3D
		public SemanticFunctionType SemanticFunctionType
		{
			get
			{
				return this._semanticFunctionType;
			}
			set
			{
				this._semanticFunctionType = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06002B4D RID: 11085 RVA: 0x001C9A46 File Offset: 0x001C7C46
		// (set) Token: 0x06002B4E RID: 11086 RVA: 0x001C9A4E File Offset: 0x001C7C4E
		public SchemaObjectName TableName
		{
			get
			{
				return this._tableName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._tableName = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06002B4F RID: 11087 RVA: 0x001C9A5E File Offset: 0x001C7C5E
		public IList<ColumnReferenceExpression> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06002B50 RID: 11088 RVA: 0x001C9A66 File Offset: 0x001C7C66
		// (set) Token: 0x06002B51 RID: 11089 RVA: 0x001C9A6E File Offset: 0x001C7C6E
		public ScalarExpression SourceKey
		{
			get
			{
				return this._sourceKey;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._sourceKey = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x001C9A7E File Offset: 0x001C7C7E
		// (set) Token: 0x06002B53 RID: 11091 RVA: 0x001C9A86 File Offset: 0x001C7C86
		public ColumnReferenceExpression MatchedColumn
		{
			get
			{
				return this._matchedColumn;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._matchedColumn = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06002B54 RID: 11092 RVA: 0x001C9A96 File Offset: 0x001C7C96
		// (set) Token: 0x06002B55 RID: 11093 RVA: 0x001C9A9E File Offset: 0x001C7C9E
		public ScalarExpression MatchedKey
		{
			get
			{
				return this._matchedKey;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._matchedKey = value;
			}
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x001C9AAE File Offset: 0x001C7CAE
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x001C9ABC File Offset: 0x001C7CBC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.TableName != null)
			{
				this.TableName.Accept(visitor);
			}
			int i = 0;
			int count = this.Columns.Count;
			while (i < count)
			{
				this.Columns[i].Accept(visitor);
				i++;
			}
			if (this.SourceKey != null)
			{
				this.SourceKey.Accept(visitor);
			}
			if (this.MatchedColumn != null)
			{
				this.MatchedColumn.Accept(visitor);
			}
			if (this.MatchedKey != null)
			{
				this.MatchedKey.Accept(visitor);
			}
		}

		// Token: 0x04001DD1 RID: 7633
		private SemanticFunctionType _semanticFunctionType;

		// Token: 0x04001DD2 RID: 7634
		private SchemaObjectName _tableName;

		// Token: 0x04001DD3 RID: 7635
		private List<ColumnReferenceExpression> _columns = new List<ColumnReferenceExpression>();

		// Token: 0x04001DD4 RID: 7636
		private ScalarExpression _sourceKey;

		// Token: 0x04001DD5 RID: 7637
		private ColumnReferenceExpression _matchedColumn;

		// Token: 0x04001DD6 RID: 7638
		private ScalarExpression _matchedKey;
	}
}
