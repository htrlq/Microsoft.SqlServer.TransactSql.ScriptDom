using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000226 RID: 550
	[Serializable]
	public class BulkOpenRowset : TableReferenceWithAliasAndColumns
	{
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06002B7C RID: 11132 RVA: 0x001C9E65 File Offset: 0x001C8065
		// (set) Token: 0x06002B7D RID: 11133 RVA: 0x001C9E6D File Offset: 0x001C806D
		public StringLiteral DataFile
		{
			get
			{
				return this._dataFile;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._dataFile = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06002B7E RID: 11134 RVA: 0x001C9E7D File Offset: 0x001C807D
		public IList<BulkInsertOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x001C9E85 File Offset: 0x001C8085
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x001C9E94 File Offset: 0x001C8094
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.DataFile != null)
			{
				this.DataFile.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001DE5 RID: 7653
		private StringLiteral _dataFile;

		// Token: 0x04001DE6 RID: 7654
		private List<BulkInsertOption> _options = new List<BulkInsertOption>();
	}
}
