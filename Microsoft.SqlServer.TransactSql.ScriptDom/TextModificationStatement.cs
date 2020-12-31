using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000263 RID: 611
	[Serializable]
	public abstract class TextModificationStatement : TSqlStatement
	{
		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x001CB8A4 File Offset: 0x001C9AA4
		// (set) Token: 0x06002CF5 RID: 11509 RVA: 0x001CB8AC File Offset: 0x001C9AAC
		public bool Bulk
		{
			get
			{
				return this._bulk;
			}
			set
			{
				this._bulk = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06002CF6 RID: 11510 RVA: 0x001CB8B5 File Offset: 0x001C9AB5
		// (set) Token: 0x06002CF7 RID: 11511 RVA: 0x001CB8BD File Offset: 0x001C9ABD
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

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06002CF8 RID: 11512 RVA: 0x001CB8CD File Offset: 0x001C9ACD
		// (set) Token: 0x06002CF9 RID: 11513 RVA: 0x001CB8D5 File Offset: 0x001C9AD5
		public ValueExpression TextId
		{
			get
			{
				return this._textId;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._textId = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06002CFA RID: 11514 RVA: 0x001CB8E5 File Offset: 0x001C9AE5
		// (set) Token: 0x06002CFB RID: 11515 RVA: 0x001CB8ED File Offset: 0x001C9AED
		public Literal Timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._timestamp = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x001CB8FD File Offset: 0x001C9AFD
		// (set) Token: 0x06002CFD RID: 11517 RVA: 0x001CB905 File Offset: 0x001C9B05
		public bool WithLog
		{
			get
			{
				return this._withLog;
			}
			set
			{
				this._withLog = value;
			}
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x001CB910 File Offset: 0x001C9B10
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Column != null)
			{
				this.Column.Accept(visitor);
			}
			if (this.TextId != null)
			{
				this.TextId.Accept(visitor);
			}
			if (this.Timestamp != null)
			{
				this.Timestamp.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E4E RID: 7758
		private bool _bulk;

		// Token: 0x04001E4F RID: 7759
		private ColumnReferenceExpression _column;

		// Token: 0x04001E50 RID: 7760
		private ValueExpression _textId;

		// Token: 0x04001E51 RID: 7761
		private Literal _timestamp;

		// Token: 0x04001E52 RID: 7762
		private bool _withLog;
	}
}
