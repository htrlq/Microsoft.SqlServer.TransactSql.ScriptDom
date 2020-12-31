using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000262 RID: 610
	[Serializable]
	public class ReadTextStatement : TSqlStatement
	{
		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x001CB7B8 File Offset: 0x001C99B8
		// (set) Token: 0x06002CE8 RID: 11496 RVA: 0x001CB7C0 File Offset: 0x001C99C0
		public ColumnReferenceExpression Column
		{
			get
			{
				return this._column;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._column = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x001CB7D0 File Offset: 0x001C99D0
		// (set) Token: 0x06002CEA RID: 11498 RVA: 0x001CB7D8 File Offset: 0x001C99D8
		public ValueExpression TextPointer
		{
			get
			{
				return this._textPointer;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._textPointer = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x001CB7E8 File Offset: 0x001C99E8
		// (set) Token: 0x06002CEC RID: 11500 RVA: 0x001CB7F0 File Offset: 0x001C99F0
		public ValueExpression Offset
		{
			get
			{
				return this._offset;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._offset = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06002CED RID: 11501 RVA: 0x001CB800 File Offset: 0x001C9A00
		// (set) Token: 0x06002CEE RID: 11502 RVA: 0x001CB808 File Offset: 0x001C9A08
		public ValueExpression Size
		{
			get
			{
				return this._size;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._size = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x001CB818 File Offset: 0x001C9A18
		// (set) Token: 0x06002CF0 RID: 11504 RVA: 0x001CB820 File Offset: 0x001C9A20
		public bool HoldLock
		{
			get
			{
				return this._holdLock;
			}
			set
			{
				this._holdLock = value;
			}
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x001CB829 File Offset: 0x001C9A29
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x001CB838 File Offset: 0x001C9A38
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Column != null)
			{
				this.Column.Accept(visitor);
			}
			if (this.TextPointer != null)
			{
				this.TextPointer.Accept(visitor);
			}
			if (this.Offset != null)
			{
				this.Offset.Accept(visitor);
			}
			if (this.Size != null)
			{
				this.Size.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E49 RID: 7753
		private ColumnReferenceExpression _column;

		// Token: 0x04001E4A RID: 7754
		private ValueExpression _textPointer;

		// Token: 0x04001E4B RID: 7755
		private ValueExpression _offset;

		// Token: 0x04001E4C RID: 7756
		private ValueExpression _size;

		// Token: 0x04001E4D RID: 7757
		private bool _holdLock;
	}
}
