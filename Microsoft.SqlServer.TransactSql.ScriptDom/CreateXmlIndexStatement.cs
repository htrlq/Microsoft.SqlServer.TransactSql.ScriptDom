using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002D3 RID: 723
	[Serializable]
	public class CreateXmlIndexStatement : IndexStatement
	{
		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06002F7E RID: 12158 RVA: 0x001CE494 File Offset: 0x001CC694
		// (set) Token: 0x06002F7F RID: 12159 RVA: 0x001CE49C File Offset: 0x001CC69C
		public bool Primary
		{
			get
			{
				return this._primary;
			}
			set
			{
				this._primary = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06002F80 RID: 12160 RVA: 0x001CE4A5 File Offset: 0x001CC6A5
		// (set) Token: 0x06002F81 RID: 12161 RVA: 0x001CE4AD File Offset: 0x001CC6AD
		public Identifier XmlColumn
		{
			get
			{
				return this._xmlColumn;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._xmlColumn = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06002F82 RID: 12162 RVA: 0x001CE4BD File Offset: 0x001CC6BD
		// (set) Token: 0x06002F83 RID: 12163 RVA: 0x001CE4C5 File Offset: 0x001CC6C5
		public Identifier SecondaryXmlIndexName
		{
			get
			{
				return this._secondaryXmlIndexName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._secondaryXmlIndexName = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06002F84 RID: 12164 RVA: 0x001CE4D5 File Offset: 0x001CC6D5
		// (set) Token: 0x06002F85 RID: 12165 RVA: 0x001CE4DD File Offset: 0x001CC6DD
		public SecondaryXmlIndexType SecondaryXmlIndexType
		{
			get
			{
				return this._secondaryXmlIndexType;
			}
			set
			{
				this._secondaryXmlIndexType = value;
			}
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x001CE4E6 File Offset: 0x001CC6E6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x001CE4F4 File Offset: 0x001CC6F4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			if (base.OnName != null)
			{
				base.OnName.Accept(visitor);
			}
			if (this.XmlColumn != null)
			{
				this.XmlColumn.Accept(visitor);
			}
			if (this.SecondaryXmlIndexName != null)
			{
				this.SecondaryXmlIndexName.Accept(visitor);
			}
			int i = 0;
			int count = base.IndexOptions.Count;
			while (i < count)
			{
				base.IndexOptions[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001F04 RID: 7940
		private bool _primary;

		// Token: 0x04001F05 RID: 7941
		private Identifier _xmlColumn;

		// Token: 0x04001F06 RID: 7942
		private Identifier _secondaryXmlIndexName;

		// Token: 0x04001F07 RID: 7943
		private SecondaryXmlIndexType _secondaryXmlIndexType;
	}
}
