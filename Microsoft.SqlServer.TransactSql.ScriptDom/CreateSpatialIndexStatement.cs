using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004B8 RID: 1208
	[Serializable]
	public class CreateSpatialIndexStatement : TSqlStatement
	{
		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06003AE7 RID: 15079 RVA: 0x001D9BD9 File Offset: 0x001D7DD9
		// (set) Token: 0x06003AE8 RID: 15080 RVA: 0x001D9BE1 File Offset: 0x001D7DE1
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06003AE9 RID: 15081 RVA: 0x001D9BF1 File Offset: 0x001D7DF1
		// (set) Token: 0x06003AEA RID: 15082 RVA: 0x001D9BF9 File Offset: 0x001D7DF9
		public SchemaObjectName Object
		{
			get
			{
				return this._object;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._object = value;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06003AEB RID: 15083 RVA: 0x001D9C09 File Offset: 0x001D7E09
		// (set) Token: 0x06003AEC RID: 15084 RVA: 0x001D9C11 File Offset: 0x001D7E11
		public Identifier SpatialColumnName
		{
			get
			{
				return this._spatialColumnName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._spatialColumnName = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06003AED RID: 15085 RVA: 0x001D9C21 File Offset: 0x001D7E21
		// (set) Token: 0x06003AEE RID: 15086 RVA: 0x001D9C29 File Offset: 0x001D7E29
		public SpatialIndexingSchemeType SpatialIndexingScheme
		{
			get
			{
				return this._spatialIndexingScheme;
			}
			set
			{
				this._spatialIndexingScheme = value;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06003AEF RID: 15087 RVA: 0x001D9C32 File Offset: 0x001D7E32
		public IList<SpatialIndexOption> SpatialIndexOptions
		{
			get
			{
				return this._spatialIndexOptions;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06003AF0 RID: 15088 RVA: 0x001D9C3A File Offset: 0x001D7E3A
		// (set) Token: 0x06003AF1 RID: 15089 RVA: 0x001D9C42 File Offset: 0x001D7E42
		public IdentifierOrValueExpression OnFileGroup
		{
			get
			{
				return this._onFileGroup;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._onFileGroup = value;
			}
		}

		// Token: 0x06003AF2 RID: 15090 RVA: 0x001D9C52 File Offset: 0x001D7E52
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003AF3 RID: 15091 RVA: 0x001D9C60 File Offset: 0x001D7E60
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.Object != null)
			{
				this.Object.Accept(visitor);
			}
			if (this.SpatialColumnName != null)
			{
				this.SpatialColumnName.Accept(visitor);
			}
			int i = 0;
			int count = this.SpatialIndexOptions.Count;
			while (i < count)
			{
				this.SpatialIndexOptions[i].Accept(visitor);
				i++;
			}
			if (this.OnFileGroup != null)
			{
				this.OnFileGroup.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002239 RID: 8761
		private Identifier _name;

		// Token: 0x0400223A RID: 8762
		private SchemaObjectName _object;

		// Token: 0x0400223B RID: 8763
		private Identifier _spatialColumnName;

		// Token: 0x0400223C RID: 8764
		private SpatialIndexingSchemeType _spatialIndexingScheme;

		// Token: 0x0400223D RID: 8765
		private List<SpatialIndexOption> _spatialIndexOptions = new List<SpatialIndexOption>();

		// Token: 0x0400223E RID: 8766
		private IdentifierOrValueExpression _onFileGroup;
	}
}
