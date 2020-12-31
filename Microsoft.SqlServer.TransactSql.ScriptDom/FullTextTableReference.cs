using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000221 RID: 545
	[Serializable]
	public class FullTextTableReference : TableReferenceWithAlias
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x001C98E0 File Offset: 0x001C7AE0
		// (set) Token: 0x06002B3C RID: 11068 RVA: 0x001C98E8 File Offset: 0x001C7AE8
		public FullTextFunctionType FullTextFunctionType
		{
			get
			{
				return this._fullTextFunctionType;
			}
			set
			{
				this._fullTextFunctionType = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x001C98F1 File Offset: 0x001C7AF1
		// (set) Token: 0x06002B3E RID: 11070 RVA: 0x001C98F9 File Offset: 0x001C7AF9
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

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06002B3F RID: 11071 RVA: 0x001C9909 File Offset: 0x001C7B09
		public IList<ColumnReferenceExpression> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06002B40 RID: 11072 RVA: 0x001C9911 File Offset: 0x001C7B11
		// (set) Token: 0x06002B41 RID: 11073 RVA: 0x001C9919 File Offset: 0x001C7B19
		public ValueExpression SearchCondition
		{
			get
			{
				return this._searchCondition;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._searchCondition = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06002B42 RID: 11074 RVA: 0x001C9929 File Offset: 0x001C7B29
		// (set) Token: 0x06002B43 RID: 11075 RVA: 0x001C9931 File Offset: 0x001C7B31
		public ValueExpression TopN
		{
			get
			{
				return this._topN;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._topN = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x001C9941 File Offset: 0x001C7B41
		// (set) Token: 0x06002B45 RID: 11077 RVA: 0x001C9949 File Offset: 0x001C7B49
		public ValueExpression Language
		{
			get
			{
				return this._language;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._language = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x001C9959 File Offset: 0x001C7B59
		// (set) Token: 0x06002B47 RID: 11079 RVA: 0x001C9961 File Offset: 0x001C7B61
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

		// Token: 0x06002B48 RID: 11080 RVA: 0x001C9971 File Offset: 0x001C7B71
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x001C9980 File Offset: 0x001C7B80
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
			if (this.SearchCondition != null)
			{
				this.SearchCondition.Accept(visitor);
			}
			if (this.TopN != null)
			{
				this.TopN.Accept(visitor);
			}
			if (this.Language != null)
			{
				this.Language.Accept(visitor);
			}
			if (this.PropertyName != null)
			{
				this.PropertyName.Accept(visitor);
			}
		}

		// Token: 0x04001DCA RID: 7626
		private FullTextFunctionType _fullTextFunctionType;

		// Token: 0x04001DCB RID: 7627
		private SchemaObjectName _tableName;

		// Token: 0x04001DCC RID: 7628
		private List<ColumnReferenceExpression> _columns = new List<ColumnReferenceExpression>();

		// Token: 0x04001DCD RID: 7629
		private ValueExpression _searchCondition;

		// Token: 0x04001DCE RID: 7630
		private ValueExpression _topN;

		// Token: 0x04001DCF RID: 7631
		private ValueExpression _language;

		// Token: 0x04001DD0 RID: 7632
		private StringLiteral _propertyName;
	}
}
