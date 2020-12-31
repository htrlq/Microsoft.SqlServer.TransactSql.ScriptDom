using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000264 RID: 612
	[Serializable]
	public class UpdateTextStatement : TextModificationStatement
	{
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06002D00 RID: 11520 RVA: 0x001CB968 File Offset: 0x001C9B68
		// (set) Token: 0x06002D01 RID: 11521 RVA: 0x001CB970 File Offset: 0x001C9B70
		public ScalarExpression InsertOffset
		{
			get
			{
				return this._insertOffset;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._insertOffset = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x001CB980 File Offset: 0x001C9B80
		// (set) Token: 0x06002D03 RID: 11523 RVA: 0x001CB988 File Offset: 0x001C9B88
		public ScalarExpression DeleteLength
		{
			get
			{
				return this._deleteLength;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._deleteLength = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06002D04 RID: 11524 RVA: 0x001CB998 File Offset: 0x001C9B98
		// (set) Token: 0x06002D05 RID: 11525 RVA: 0x001CB9A0 File Offset: 0x001C9BA0
		public ColumnReferenceExpression SourceColumn
		{
			get
			{
				return this._sourceColumn;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._sourceColumn = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x001CB9B0 File Offset: 0x001C9BB0
		// (set) Token: 0x06002D07 RID: 11527 RVA: 0x001CB9B8 File Offset: 0x001C9BB8
		public ValueExpression SourceParameter
		{
			get
			{
				return this._sourceParameter;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._sourceParameter = value;
			}
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x001CB9C8 File Offset: 0x001C9BC8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x001CB9D4 File Offset: 0x001C9BD4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.InsertOffset != null)
			{
				this.InsertOffset.Accept(visitor);
			}
			if (this.DeleteLength != null)
			{
				this.DeleteLength.Accept(visitor);
			}
			if (this.SourceColumn != null)
			{
				this.SourceColumn.Accept(visitor);
			}
			if (this.SourceParameter != null)
			{
				this.SourceParameter.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E53 RID: 7763
		private ScalarExpression _insertOffset;

		// Token: 0x04001E54 RID: 7764
		private ScalarExpression _deleteLength;

		// Token: 0x04001E55 RID: 7765
		private ColumnReferenceExpression _sourceColumn;

		// Token: 0x04001E56 RID: 7766
		private ValueExpression _sourceParameter;
	}
}
