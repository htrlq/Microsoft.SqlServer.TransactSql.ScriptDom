using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000307 RID: 775
	[Serializable]
	public class UpdateStatisticsStatement : TSqlStatement
	{
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060030AF RID: 12463 RVA: 0x001CF8A6 File Offset: 0x001CDAA6
		// (set) Token: 0x060030B0 RID: 12464 RVA: 0x001CF8AE File Offset: 0x001CDAAE
		public SchemaObjectName SchemaObjectName
		{
			get
			{
				return this._schemaObjectName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._schemaObjectName = value;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060030B1 RID: 12465 RVA: 0x001CF8BE File Offset: 0x001CDABE
		public IList<Identifier> SubElements
		{
			get
			{
				return this._subElements;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060030B2 RID: 12466 RVA: 0x001CF8C6 File Offset: 0x001CDAC6
		public IList<StatisticsOption> StatisticsOptions
		{
			get
			{
				return this._statisticsOptions;
			}
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x001CF8CE File Offset: 0x001CDACE
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x001CF8DC File Offset: 0x001CDADC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SchemaObjectName != null)
			{
				this.SchemaObjectName.Accept(visitor);
			}
			int i = 0;
			int count = this.SubElements.Count;
			while (i < count)
			{
				this.SubElements[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.StatisticsOptions.Count;
			while (j < count2)
			{
				this.StatisticsOptions[j].Accept(visitor);
				j++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F5A RID: 8026
		private SchemaObjectName _schemaObjectName;

		// Token: 0x04001F5B RID: 8027
		private List<Identifier> _subElements = new List<Identifier>();

		// Token: 0x04001F5C RID: 8028
		private List<StatisticsOption> _statisticsOptions = new List<StatisticsOption>();
	}
}
